using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace FTP
{
    public class FTPOperations
    {

        private Credentials _credentials;

        public Credentials credentials{
            get { return _credentials; }
            set { _credentials = value; }
        }

        private string CreateFTPPath(string path)
        {
            return $"ftp://{credentials.server}/{path}";
        }

        private string CreateDownloadPath(string downloadPath, string fileName)
        {
            return $"{downloadPath}/{fileName}";
        }

        private FtpWebRequest CreateFtpRequest(string method, string path)
        {
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(CreateFTPPath(path));
            ftpRequest.Credentials = credentials.GetNetworkCredentials();
            ftpRequest.Method = method;
            return ftpRequest;
        }

        private FtpWebRequest CreateFtpRequest(string method)
        {
            return CreateFtpRequest(method, "./");
        }

        public bool CheckCredentials()
        {
            FtpWebRequest ftpRequest = CreateFtpRequest(WebRequestMethods.Ftp.PrintWorkingDirectory);
            try
            {
                using (FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private List<string> ListDirectory(string path)
        {
            FtpWebRequest ftpRequest = CreateFtpRequest(WebRequestMethods.Ftp.ListDirectory, path);
            try
            {
                using (FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                {
                    return FileUtils.ReadToList(response.GetResponseStream());
                }
            }
            catch
            {
                return null;
            }

        }

        public List<KeyValuePair<string, string>> DownloadFiles(string basePath, string downloadPath, string doneDirectory, string extension)
        {
            List<KeyValuePair<string, string>> logs = new List<KeyValuePair<string, string>>();

            logs.Add(GenerateLog("INFO", "Checking for new files..."));

            var files = ListDirectory(basePath);
            if (files != null)
            {
                var ediFiles = files.Where((s, i) => s.EndsWith(extension));

                if (ediFiles.AsEnumerable().ToList().Count == 0)
                {
                    logs.Add(GenerateLog("OK", "No new files to download"));
                }

                foreach (string fileName in ediFiles)
                {
                    if (DownloadFile(fileName, downloadPath, logs))
                    {
                        MoveFile(fileName, doneDirectory, logs);
                    }
                }
            }
            else
            {
                logs.Add(GenerateLog("ERROR", "Couldn't reach directory to download."));
            }
            return logs;
        }

        private bool DownloadFile(string fileName, string downloadPath, List<KeyValuePair<string, string>> logs)
        {
            logs.Add(GenerateLog("INFO", $"Downloading file {fileName}..."));

            FtpWebRequest ftpRequest = CreateFtpRequest(WebRequestMethods.Ftp.DownloadFile, fileName);
            try
            {
                using (FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                {
                    string result = FileUtils.StreamToFile(response.GetResponseStream(), CreateDownloadPath(downloadPath, fileName));
                    if (result is null) logs.Add(GenerateLog("OK", $"Download finished with status {response.StatusDescription}"));
                    else logs.Add(GenerateLog("ERROR", $"Writing file {fileName} on {downloadPath} failed with error {result}"));
                    return true;
                }
            }
            catch(Exception e)
            {
                logs.Add(GenerateLog("ERROR", $"Downloading file {fileName} failed with error: {e.Message}"));
                return false;
            }
        }

        public List<KeyValuePair<string, string>> UploadFile(string originalFilePath)
        {
            List<KeyValuePair<string, string>> logs = new List<KeyValuePair<string, string>>();

            string fileName = Path.GetFileName(originalFilePath);
            logs.Add(GenerateLog("INFO", $"Uploading file {fileName}..."));

            byte[] content = FileUtils.FileToByteArray(originalFilePath);
            if (content is null)
            {
                logs.Add(GenerateLog("ERROR", $"Could not read file {fileName}"));
            }
            else
            {
                FtpWebRequest ftpRequest = CreateFtpRequest(WebRequestMethods.Ftp.UploadFile, fileName);
                ftpRequest.ContentLength = content.Length;
                try
                {
                    Stream stream = ftpRequest.GetRequestStream();
                    stream.Write(content, 0, content.Length);
                    stream.Close();
                    using (FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                    {
                        logs.Add(GenerateLog("OK", $"Upload finished with status {response.StatusDescription}"));

                    }
                }
                catch(Exception e)
                {
                    logs.Add(GenerateLog("ERROR", $"Uploading file {fileName} failed with error: {e.Message}"));
                }
                
            }

            return logs;
        }

        private void MoveFile(string fileName, string moveToDirectory, List<KeyValuePair<string, string>> logs)
        {
            logs.Add(GenerateLog("INFO", $"Moving file {fileName} to {moveToDirectory}..."));

            FtpWebRequest ftpRequest = CreateFtpRequest(WebRequestMethods.Ftp.Rename, fileName);
            ftpRequest.RenameTo = $"./{moveToDirectory}/{fileName}";

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                {
                    logs.Add(GenerateLog("OK", $"Moving file finished with status {response.StatusDescription}"));
                }
            }
            catch (Exception e)
            {
                logs.Add(GenerateLog("ERROR", $"Moving {fileName} to {moveToDirectory} failed: {e.Message}"));
            }
        }

        private KeyValuePair<string, string> GenerateLog(string status, string message)
        {
            return new KeyValuePair<string, string>(frmFTP.LogStatus(status), message);
        }

    }
}
