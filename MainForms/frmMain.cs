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
using CustomControls;
using Utils;
using DataAccess;

namespace MainForms
{
    public partial class frmMain : Form
    {
        private AccesADades accesADades;
        string loggedUser;
        bool isLogout = false;
        private DataSet dts;

        public string LoggedUser { get => loggedUser; set => loggedUser = value; }

        public bool IsLogout { get => isLogout; set => isLogout = value; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void LoadUserInfo()
        {
            lblUsuari.Text = loggedUser;
            Refresh();
            //obtener imagen de bbdd
        }


        private void AddFormsList()
        {
            foreach (DataRow row in dts.Tables[0].Rows)
            {
                try
                {
                    SWLaunchForm swLaunchForm = new SWLaunchForm(pnlPpal);
                    swLaunchForm.Library = row["namespace"].ToString();
                    swLaunchForm.Form = row["formName"].ToString();
                    swLaunchForm.Description = row["description"].ToString();
                    swLaunchForm.ImageBtn = ImageUtils.GetImageFromUrl(row["image"].ToString());
                    //swLaunchForm.Dock = DockStyle.Fill;

                    pnlMenu.Controls.Add(swLaunchForm);
                }
                catch (Exception) { }

            };
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
            // El codi que pertany a aquest apartat està en el SWLaunchForm
            //string formClass = String.Format("MainForms.dll");
            //Assembly ensamblat = Assembly.LoadFrom(@formClass);
            //Object dllBD;

            //Type tipus;

            //string formType = String.Format("{0}.{1}", "MainForms", formName);
            //tipus = ensamblat.GetType(formType);

            // Aquest apartat s'ha de mantenir aquí després de realitzar el click
            //Form form = activeForm(pnlPpal, tipus);

            //if (form == null)
            //{
            //    dllBD = Activator.CreateInstance(tipus);
            //    form = ((Form)dllBD);
            //    form.TopLevel = false;
            //    form.Dock = DockStyle.Fill;
            //    pnlPpal.Controls.Add(form);
            //    form.Show();
            //}
            //else
            //{
            //    form.BringToFront();
            //}
            //setActiveColor((Button)btn);
        }

        private void GetOptions()
        {
            dts = accesADades.PortarPerConsulta("Select * FROM userOptions");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            accesADades = new AccesADades("SecureCore");
            LoadUserInfo();
            GetOptions();
            AddFormsList();
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLogout)
            {
                Application.Exit();
            }
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
