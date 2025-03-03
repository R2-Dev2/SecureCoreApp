using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FTP
{
    public static class FTPUtils
    {
        public static bool CheckInternetConnection()
        {
            return NetworkInterface.GetIsNetworkAvailable();       
        }

        public static bool CheckFTPConnection(Credentials credentials)
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(credentials.server, 1000);
                    if (reply.Status == IPStatus.Success) count++;
                }
                catch (Exception) { };

            }
            return count >= 8;
        }

        public static Credentials GetCredentialsFromFile(string credentialsXml, string serverPath, string usernamePath, string pwdPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(credentialsXml);

            string ftpServer = doc.SelectSingleNode(serverPath)?.InnerText;
            string username = doc.SelectSingleNode(usernamePath)?.InnerText;
            string password = doc.SelectSingleNode(pwdPath)?.InnerText;

            if (string.IsNullOrEmpty(ftpServer) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            Credentials credentials = new Credentials();
            credentials.server = ftpServer;
            credentials.username = username;
            credentials.password = password;

            return credentials;
        }
    }
}
