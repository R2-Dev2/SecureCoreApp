using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainForms;

namespace LoginForms
{
    public partial class frmLogin : Form
    {
        readonly int MAX_TRIES = 3;
        bool knownUser = false;
        int tries = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!knownUser)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tries++;
            if (txtUser.Text == "Sandy" && txtPwd.Text == "1234")
            {
                closeOpenedMain();
                knownUser = true;

                //frmValidacioOk frmOk = new frmValidacioOk();
                //frmOk.ShowDialog();

                frmMain frmMain = new frmMain();
                frmMain.LoggedUser = txtUser.Text;
                frmMain.Show();

                this.Close();
            }
            else
            {
                txtPwd.Clear();
                lblIncorrect.Show();
                int triesLeft = MAX_TRIES - tries;
                lblTriesLeft.Text = triesLeft + " tries left.";
                lblTriesLeft.Show();
                if (tries >= MAX_TRIES)
                {
                    launchWarningMessage();
                }
            }
        }

        private void closeOpenedMain()
        {
            bool isMain = false;
            Form form = new Form();

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "frmMain")
                {
                    isMain = true;
                    form = item;
                }
            }
            if (isMain)
            {
                frmMain main = (frmMain)form;
                main.IsLogout = true;
            }

            form.Close();
        }

        private void launchWarningMessage()
        {
            frmValidationWrong frmValidationWrong = new frmValidationWrong();
            frmValidationWrong.ShowDialog();
        }
    }
}
