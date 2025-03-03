using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace FTP
{
    public partial class frmUpdateCredentials : Form
    {
        private frmFTP _frmFTP;

        public frmFTP frmFTP
        {
            get { return _frmFTP; }
            set {
                _frmFTP = value;
                txtServer.Text = frmFTP.credentials.server;
                txtUsername.Text = frmFTP.credentials.username;
                txtPwd.Text = frmFTP.credentials.password;
            }
        }

        public frmUpdateCredentials()
        {
            InitializeComponent();
        }

        private void UpdateCredentials()
        {
            Dictionary<string, string> fieldsToUpdate = new Dictionary<string, string>();
            if (txtServer.Text != frmFTP.credentials.server)
            {
                fieldsToUpdate.Add(frmFTP.serverPath, txtServer.Text);
            }

            if (txtUsername.Text != frmFTP.credentials.server)
            {
                fieldsToUpdate.Add(frmFTP.usernamePath, txtUsername.Text);
            }

            if (!string.IsNullOrEmpty(txtPwd.Text) && txtPwd.Text != frmFTP.credentials.password)
            {
                fieldsToUpdate.Add(frmFTP.pwdPath, txtPwd.Text);
            }

            bool status = FileUtils.UpdateXmlFields(frmFTP.credentialsPath, fieldsToUpdate);
            if (status) frmFTP.isCredentialsChanged = true;
            ShowMessage(status);
        }

        private void ShowMessage(bool isSuccessful)
        {
            if (isSuccessful)
            {
                lblStatus.Text = "Credentials updated successfully";
                lblStatus.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblStatus.Text = "Couldn't update credentials";
                lblStatus.ForeColor = Color.Red;
            }
            lblStatus.Visible = true;
            Task.Delay(3000).ContinueWith(_ =>
            {
                try
                {
                    Invoke(new MethodInvoker(() => { lblStatus.Visible = false; }));
                }
                catch (Exception) { };
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateCredentials();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
