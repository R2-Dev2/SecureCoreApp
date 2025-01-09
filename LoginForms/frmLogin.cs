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
        private bool isFirstLogin;
        private string idUser;
        private AccesADades accesADades;
        private Dictionary<string, string> dict = new Dictionary<string, string>();
        bool knownUser = false;
        int tries = 0;
        int counter = 0;
        public frmLogin(bool isFirstLogin)
        {
            this.isFirstLogin = isFirstLogin;
            InitializeComponent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!knownUser && isFirstLogin)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tries++;
            bool isValid = false;
            bool isChangeOfPassword = false;
            dict.Clear();
            dict.Add("Login", txtUser.Text);
            
            string userPassword = txtPwd.Text;
            string query = $"SELECT idUser, Password, Salt FROM {this.tableName} WHERE 1 = 1";
            DataSet dts = accesADades.ExecutaCercaQuery(query, dict);

            if (dts.Tables[0].Rows.Count == 1)
            {
                pbvalidacio.Image = LoginForms.Properties.Resources.validacioEstatPrevi;
                string idUser = dts.Tables[0].Rows[0]["idUser"].ToString();
                string savedPassword = dts.Tables[0].Rows[0]["password"].ToString();
                if (userPassword == DEFAULT_PWD && savedPassword == DEFAULT_PWD)
                {
                    isChangeOfPassword = true;
                    frmLoginChangePass frm = new frmLoginChangePass();
                    frm.idUser = idUser;
                    txtPwd.Clear();
                    tries = 0;
                    lblIncorrect.Visible = false;
                    lblTriesLeft.Visible = false;
                    txtPwd.Focus();
                    frm.ShowDialog();
                }
                else
                {
                    string salt = dts.Tables[0].Rows[0]["salt"].ToString();
                    if (HashingUtils.VerifyPassword(userPassword, salt, savedPassword))
                    {
                        isValid = true;
                        knownUser = true;
                        timerValidating.Start();

                        lblTriesLeft.Visible = false;
                        lblIncorrect.Visible = false;
                        pbvalidacio.Image = LoginForms.Properties.Resources.validacioCorrecta;
                        lblVerificantNivell.Text = "Verifying user access.";
                        lblBenvinguda.Text = $"Welcome, {txtUser.Text}!";
                        this.idUser = dts.Tables[0].Rows[0]["idUser"].ToString();
                    }
                }
            }

            if (!isValid && !isChangeOfPassword)
            {
                txtPwd.Clear();
                lblIncorrect.Visible = true;
                int triesLeft = MAX_TRIES - tries;
                lblTriesLeft.Text = triesLeft + " tries left.";
                pbvalidacio.Image = LoginForms.Properties.Resources.validacioIncorrecta;
                lblTriesLeft.Visible = true;
                txtPwd.Focus();
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
                main.isLogout = true;
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
            if (!isFirstLogin)
            {
                closeOpenedMain();
            }
            this.accesADades = new AccesADades("SecureCore");
        }

        private void TimerValidating_Tick(object sender, EventArgs e)
        {
            counter++;

            lblVerificantNivell.Text = "Verifying user access.";

            if (counter % 2 == 0)
            {
                lblVerificantNivell.Text += ".";
            }
            else
            {
                lblVerificantNivell.Text += "..";
            }

            if (counter == 10)
            {
                timerValidating.Stop();

                frmMain frmMain = new frmMain();
                frmMain.idUser = idUser;
                frmMain.Show();

                this.Close();
            }
        }
    }
}
