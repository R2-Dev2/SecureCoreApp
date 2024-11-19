using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class frmMain : Form
    {
        string loggedUser;
        bool isLogout = false;
        public string LoggedUser
        {
            get => loggedUser;
            set
            {
                loggedUser = value;
                loadUserInfo();
            }
        }

        public bool IsLogout { get => isLogout; set => isLogout = value; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void loadUserInfo()
        {
            lblUsuari.Text = loggedUser;
            Refresh();
            //obtener imagen de bbdd
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLogout)
            {
                Application.Exit();
            }
        }

        private void setActiveColor(Button btn)
        {
            foreach (Control ctrl in pnlMenu.Controls)
            {
                if (ctrl is Button)
                {
                    if (ctrl.Name == btn.Name)
                    {
                        ctrl.BackColor = Color.CadetBlue;
                    }
                    else
                    {
                        ctrl.BackColor = Color.PowderBlue;
                    }
                }
            }
        }

        private void btnSpecies_Click(object sender, EventArgs e)
        {
            showForm(new frmSpecies(), (Button)sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            showForm(new frmUsers(), (Button)sender);
        }

        private void showForm(Form form, Button btn)
        {
            pnlPpal.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlPpal.Controls.Add(form);
            form.Show();
            setActiveColor((Button)btn);
        }

        private void pbUser_Click(object sender, EventArgs e)
        {
           // frmLoginOptions frmLoginOptions = new frmLoginOptions();
           // frmLoginOptions.ShowDialog();
        }
    }
}
