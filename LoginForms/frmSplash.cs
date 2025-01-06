using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForms;

namespace LoginForms
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            Percentatge.Text = progressBar.Value.ToString() + "%";

            if (progressBar.Value == progressBar.Maximum)
            {
                timer.Stop();

                 frmLogin frm = new frmLogin(true);
                 frm.Show();

                this.Hide();
            }
            else
            {
                int xPosition = 120 + (int)((this.Width - 150) * (progressBar.Value / 180.0));
                int xPosition2 = 60 + (int)((this.Width - 150) * (progressBar.Value / 180.0));
                int xPosition3 = -15 + (int)((this.Width - 150) * (progressBar.Value / 180.0));
                int xPosition4 = -90 + (int)((this.Width - 150) * (progressBar.Value / 180.0));

                if (progressBar.Value == 34)
                {
                    pbProgress2.Visible = true;
                }
                else if (progressBar.Value == 68)
                {
                    pbProgress3.Visible = true;
                }
                else if (progressBar.Value == 96)
                {
                    pbProgress4.Visible = true;
                }

                pbProgress.Location = new Point(xPosition, pbProgress.Location.Y);
                pbProgress2.Location = new Point(xPosition2, pbProgress.Location.Y);
                pbProgress3.Location = new Point(xPosition3, pbProgress.Location.Y);
                pbProgress4.Location = new Point(xPosition4, pbProgress.Location.Y);
            }
        }
    }
}
