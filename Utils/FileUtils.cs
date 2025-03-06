using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms;

namespace Utils
{
    public static class FileUtils
    {
        public static string GetFileFromOpenDialog(string extension)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = $"Files allowed |*{extension}";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }

        public static List<string> ReadToList(Stream stream)
        {
            List<string> list = new List<string>();
            using (StreamReader streamReader = new StreamReader(stream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            return list;
        }

        public static string StreamToFile(Stream stream, string downloadPath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string content = reader.ReadToEnd();
                    string result = CreateDirectoryIfNotExists(Path.GetDirectoryName(downloadPath));
                    if (result != null) return result;
                    File.WriteAllText(downloadPath, content);
                }
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static byte[] FileToByteArray(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    return File.ReadAllBytes(filePath);
                }
                catch
                {
                    return null;
                }
            }   
            return null;
        }

        public static bool UpdateXmlFields(string path, Dictionary<string, string> fields)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            if (doc is null) return false;

            foreach (KeyValuePair<string, string> pair in fields)
            {
                XmlNode node = doc.SelectSingleNode(pair.Key);
                node.InnerText = pair.Value;
            }
            doc.Save(path);
            return true;
        }

        private static string CreateDirectoryIfNotExists(string directory)
        {
            if (!Directory.Exists(directory))
            {
                try
                {
                    Directory.CreateDirectory(directory);
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return null;
        }
    }
}