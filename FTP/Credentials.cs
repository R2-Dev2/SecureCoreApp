using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FTP
{
    public class Credentials
    {
        private string _server;
        private string _username;
        private string _password;
        private bool _isCorrect = false;

        public string server
        {
            get { return _server; }
            set { _server = value; }
        }

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool isCorrect
        {
            get { return _isCorrect;  }
            set { _isCorrect = value; }
        } 

        public NetworkCredential GetNetworkCredentials()
        {
            return new NetworkCredential(username, password);
        }
    }
}
