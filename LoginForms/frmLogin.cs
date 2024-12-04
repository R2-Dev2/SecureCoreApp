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
using DataAccess;
using Utils;

namespace LoginForms
{
    public partial class frmLogin : Form
    {
        private readonly string tableName = "Users";
        private readonly string DEFAULT_PWD = "12345aA";
        private readonly int MAX_TRIES = 3;
        private AccesADades accesADades;
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

            string username = txtUser.Text;
            string userPassword = txtPwd.Text;
            string query = $"SELECT idUser, password, salt FROM {this.tableName} WHERE username = '{username}'";
            DataSet dts = accesADades.PortarPerConsulta(query);

            if (dts.Tables[0].Rows.Count == 1)
            {
                string idUser = dts.Tables[0].Rows[0]["idUser"].ToString();
                string savedPassword = dts.Tables[0].Rows[0]["password"].ToString();
                if (userPassword == DEFAULT_PWD && savedPassword == DEFAULT_PWD)
                {
                    frmLoginChangePass frm = new frmLoginChangePass();
                    frm.idUser = idUser;
                    txtPwd.Clear();
                    tries = 0;
                    lblIncorrect.Hide();
                    lblTriesLeft.Hide();
                    frm.ShowDialog();

                }
                else
                {
                    string salt = dts.Tables[0].Rows[0]["salt"].ToString();
                    if (HashingUtils.VerifyPassword(userPassword, salt, savedPassword))
                    {

                        closeOpenedMain();
                        knownUser = true;

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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.accesADades = new AccesADades("SecureCore");
        }
    }
}
