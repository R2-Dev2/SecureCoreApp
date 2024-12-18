using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            showForm("frmSpecies", (Button)sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            showForm("frmUsers", (Button)sender);
        }
        private void btnSpaceShipsTypes_Click(object sender, EventArgs e)
        {
            showForm("frmSpaceShipsTypesMant", (Button)sender);
        }

        private Form activeForm (Control father, Type tipus)
        {
            foreach (Form control in father.Controls)
            {
                if (control.GetType() == tipus)
                {
                    return control;
                }
            }
            return null;
        }

        private void showForm(string formName, Button btn)
        {
            string formClass = String.Format("MainForms");
            if(formName == "frmSpaceShipsTypesMant")
            {
                formClass = "SpaceShipsTypes";
            }
            Assembly ensamblat = Assembly.LoadFrom($@"{formClass}.dll");
            Object dllBD;

            Type tipus;

        //    string formType = String.Format("{0}.{1}", "MainForms", formName);
            tipus = ensamblat.GetType($"{formClass}.{formName}");
         //   tipus = ensamblat.GetType(formType);

            Form form = activeForm(pnlPpal, tipus);

            if (form == null)
            {
                dllBD = Activator.CreateInstance(tipus);
                form = ((Form)dllBD);
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                pnlPpal.Controls.Add(form);
                form.Show();
            }
            else
            {
                form.BringToFront();
            }
            setActiveColor((Button)btn);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            // frmLoginOptions frmLoginOptions = new frmLoginOptions();
            // frmLoginOptions.ShowDialog();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the session?", "Log out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               Application.Exit();
            }
        }
    }
}
