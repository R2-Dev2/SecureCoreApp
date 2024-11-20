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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            Percentatge.Text = progressBar.Value.ToString() + "%";

            if (progressBar.Value == progressBar.Maximum)
            {
                timer.Stop();

                // Login frmLogin = new Login();
                // frmLogin.Show();

                this.Hide();
            }
        }
    }
}
