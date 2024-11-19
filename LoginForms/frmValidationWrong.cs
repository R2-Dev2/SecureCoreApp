using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForms
{
    public partial class frmValidationWrong : Form
    {
        public frmValidationWrong()
        {
            InitializeComponent();
        }

        private void frmValidationWrong_MouseMove(object sender, MouseEventArgs e)
        {
            lblDeath.Refresh();
            lblWarning.Refresh();
            System.Threading.Thread.Sleep(5000);
            Application.Exit();
        }
    }
}
