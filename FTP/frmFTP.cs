using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Utils;

namespace FTP
{
    public partial class frmFTP : Form
    {
        private string FILE_EXTENSION = ".edi";
        private string DONE_DIRECTORY = "tractats";

        private FTPOperations ftpOperations;

        private string _credentialsPath;
        private string _serverPath;
        private string _usernamePath;
        private string _pwdPath;
        private string _downloadsDirectory;
        private Credentials _credentials;

        private bool _isCredentialsChanged = false;
        private bool isConnectionOk = false;

        public string credentialsPath
        {
            get { return _credentialsPath; }
            set { _credentialsPath = value; }
        }

        public string serverPath
        {
            get { return _serverPath; }
            set { _serverPath = value; }
        }

        public string usernamePath
        {
            get { return _usernamePath; }
            set { _usernamePath = value; }
        }

        public string pwdPath
        {
            get { return _pwdPath; }
            set { _pwdPath = value; }
        }

        public string downloadsDirectory
        {
            get { return _downloadsDirectory; }
            set { 
                _downloadsDirectory = value;
                txtDownloadDir.Text = downloadsDirectory;
            }
        }

        public Credentials credentials
        {
            get { return _credentials; }
            set {_credentials = value; }
        }

        public bool isCredentialsChanged
        {
            get { return _isCredentialsChanged; }
            set { _isCredentialsChanged = value; }
        }

        public frmFTP()
        {
            InitializeComponent();
        }

        private void LoadCredentials()
        {
            AddLog("INFO", "Loading credentials...");

            if (!File.Exists(this.credentialsPath))
            {
                AddLog("ERROR", "Credentials file not found");
                AddEmptyLine();
                return;
            }

            this.credentials = FTPUtils.GetCredentialsFromFile(this.credentialsPath, this.serverPath, this.usernamePath, this.pwdPath);
            
            if(this.credentials is null)
            {
                AddLog("ERROR", "Incorrect or missing data on credentials file");
            }
            else
            {
                this.ftpOperations = new FTPOperations();
                this.ftpOperations.credentials = this.credentials;

                AddLog("OK", "Credentials loaded successfully");
            }
            AddEmptyLine();
        }

        private void CheckConnection()
        {
            AddLog("INFO", "Checking connection...");

            bool networkAvailable = FTPUtils.CheckInternetConnection();
            if (!networkAvailable)
            {
                AddLog("ERROR", "Network not available");
                this.isConnectionOk = false;
            }            
            else
            {
                AddLog("OK", "Network available");

                if (credentials is null)
                {
                    AddLog("ERROR", "Can't check FTP connection without proper credentials");
                    return;
                }
                AddLog("INFO", "Checking FTP connection...");

                if (FTPUtils.CheckFTPConnection(credentials))
                {
                    AddLog("OK", "Connection to FTP successful");
                    this.isConnectionOk = true;
                    CheckCredentials();
                }
                else
                {
                    AddLog("ERROR", "FTP connection failed");
                    this.isConnectionOk = false;
                }
            }
            AddEmptyLine();
        }

        private void CheckCredentials()
        {
            if (ftpOperations.CheckCredentials())
            {
                AddLog("OK", "Logged in to FTP server successfully");
                this.credentials.isCorrect = true;
            }
            else
            {
                AddLog("ERROR", "Failed to log in, please make sure credentials are correct");
                this.credentials.isCorrect = false;
            }
        }

        private void DownloadFiles()
        {
            if (!isConnectionOk)
            {
                AddLog("ERROR", "Connection is not working, can't download files");
            }
            else if (!credentials.isCorrect)
            {
                AddLog("ERROR", "Could not log in, please check credentials and try again");
            }
            else
            {
                List<KeyValuePair<string, string>> logs = ftpOperations.DownloadFiles("/", this._downloadsDirectory, this.DONE_DIRECTORY, this.FILE_EXTENSION);
                AddLogs(logs);
            }
            AddEmptyLine();
        }

        private void UploadFile()
        {
            if (!isConnectionOk)
            {
                AddLog("ERROR", "Connection is not working, can't upload files");
            }
            else if (!credentials.isCorrect)
            {
                AddLog("ERROR", "Could not log in, please check credentials and try again");
            }
            else
            {
                string filePath = FileUtils.GetFileFromOpenDialog(FILE_EXTENSION);
                if(filePath != null)
                {
                    AddLogs(ftpOperations.UploadFile(filePath));
                }
            }
            AddEmptyLine();
        }

        private void AddLogs(List<KeyValuePair<string, string>> logs)
        {
            foreach(KeyValuePair<string, string> log in logs)
            {
                AddLog(log.Key, log.Value);
            }
        }

        private void AddLog(string status, string message)
        {
            lsbInfo.Items.Add(LogStatus(status) + message);
        }   

        private void AddEmptyLine()
        {
            lsbInfo.Items.Add("");
        }

        public static string LogStatus(string status)
        {
            if (status.StartsWith("[")) return status;
            return $"[{DateTime.Now:HH:mm:ss}][{status}]: ";
        }

        private void frmFTP_Load(object sender, EventArgs e)
        {
            this.credentialsPath = "./resources/credentials.xml";
            this.serverPath = "/FTP/ip";
            this.usernamePath = "/FTP/credentials/username";
            this.pwdPath = "/FTP/credentials/password";
            this.downloadsDirectory = "C:/temp";

            LoadCredentials();
            CheckConnection();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DownloadFiles();
        }

        private void btnChangeDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.downloadsDirectory = $"{dialog.SelectedPath}/";
            }
        }

        private void btnUpdateCredentials_Click(object sender, EventArgs e)
        {
            frmUpdateCredentials frmUpdateCredentials = new frmUpdateCredentials();
            frmUpdateCredentials.frmFTP = this;
            frmUpdateCredentials.ShowDialog();

            if (isCredentialsChanged)
            {
                LoadCredentials();
                CheckConnection();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            UploadFile();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
