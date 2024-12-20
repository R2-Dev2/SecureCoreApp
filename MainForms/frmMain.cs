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
        string rangeOption;
        bool isLogout = false;
        private DataSet dts;

        public string LoggedUser { get => loggedUser; set => loggedUser = value; }

        public string RangeOption { get => rangeOption; set => rangeOption = value; }

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

        private void setActiveColor(Button btn) // unused 
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

        private void GetOptions()
        {
            dts = accesADades.PortarPerConsulta($"Select * FROM userOptions WHERE rangeOption <= {rangeOption}");
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
