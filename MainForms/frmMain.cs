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
        string rangeOption;
        string idUser;
        bool isLogout = false;
        private DataSet dtsOptions;
        private DataSet dtsUser;

        public string RangeOption { get => rangeOption; set => rangeOption = value; }
        public string IdUser { get => idUser; set => idUser = value; }
        public bool IsLogout { get => isLogout; set => isLogout = value; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void LoadUserInfo()
        {
            lblUsuari.Text = dtsUser.Tables[0].Rows[0]["Login"].ToString();
            Refresh();
            Image img = ImageUtils.GetImageFromDataBase(dtsUser.Tables[0].Rows[0]["Photo"]);
            if (img is null)
            {
                img = pbUsari.ErrorImage;
            }
            pbUsari.Image = img;
        }


        private void AddFormsList()
        {
            foreach (DataRow row in dtsOptions.Tables[0].Rows)
            {
                try
                {
                    SWLaunchForm swLaunchForm = new SWLaunchForm(pnlPpal);
                    swLaunchForm.Library = row["namespace"].ToString();
                    swLaunchForm.Form = row["formName"].ToString();
                    swLaunchForm.Description = row["description"].ToString();
                    swLaunchForm.ImageBtn = ImageUtils.GetImageFromRelativePath(row["image"].ToString());

                    pnlMenu.Controls.Add(swLaunchForm);
                }
                catch (Exception) { }

            };
        }

        private void GetOptions()
        {
            dtsOptions = accesADades.PortarPerConsulta($"Select * FROM userOptions WHERE rangeOption <= {rangeOption}");
        }

        private void LoginOptions()
        {
            frmUserOptions frmUserOptions = new frmUserOptions(this);
            frmUserOptions.ShowDialog();
        }

        public void LaunchEditProfileForm()
        {
            string namespaceUserProfile = "Users";
            string frmUserProfile = "frmUserProfile";
            
            Assembly assembly = Assembly.LoadFrom($@"{namespaceUserProfile}.dll");
            Object dllBD;
            Type type;

            type = assembly.GetType($"{namespaceUserProfile}.{frmUserProfile}");
            Object[] args = { this.idUser };
            dllBD = Activator.CreateInstance(type, args);
            Form frm = (Form)dllBD;

            frm.ShowDialog();
            GetUserData();
            LoadUserInfo();
        }

        private void GetUserData()
        {
            string query = $"SELECT idUser, Login, AccessLevel, Photo FROM Users as u, UserCategories as uc WHERE u.idUser = '{this.idUser}' AND u.idUserCategory = uc.idUserCategory;";

            dtsUser = accesADades.PortarPerConsulta(query);
            this.rangeOption = dtsUser.Tables[0].Rows[0]["AccessLevel"].ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            accesADades = new AccesADades("SecureCore");
            GetUserData();
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
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the session?", "Log out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               Application.Exit();
            }
        }

        private void pbUsari_Click(object sender, EventArgs e)
        {
            LoginOptions();
        }

        private void lblUsuari_Click(object sender, EventArgs e)
        {
            LoginOptions();
        }
    }
}
