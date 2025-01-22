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
    public partial class frmUserOptions : Form
    {
        private frmMain frmMain;

        public frmUserOptions(frmMain frmMain)
        {
            this.frmMain = frmMain;
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            string namespaceLogin = "LoginForms";
            string frmLogin = "frmLogin";

            Assembly assembly = Assembly.LoadFrom($@"{namespaceLogin}.dll");
            Object dllBD;
            Type type;

            type = assembly.GetType($"{namespaceLogin}.{frmLogin}");
            Object[] args = { false };
            dllBD = Activator.CreateInstance(type, args);
            Form frm = (Form)dllBD;

            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmMain.LaunchEditProfileForm();
            this.Close();
        }
    }
}
