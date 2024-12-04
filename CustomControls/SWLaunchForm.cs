using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CustomControls
{
    public partial class SWLaunchForm : UserControl
    {
        private string library;
        private string form;
        private string description;
        private Image imagebtn;

        public SWLaunchForm()
        {
            InitializeComponent();
        }

        public string Library
        {
            get { return library; }
            set { library = value; }
        }

        public string Form
        {
            get { return form; }
            set { form = value; }
        }

        public Image ImageBtn
        {
            get { return imagebtn; }
            set
            {
                imagebtn = value;
                if (imagebtn != null)
                {
                    pbImage.Image = imagebtn;
                }
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                if (!string.IsNullOrEmpty(description))
                {
                    lblTextBtn.Text = description;
                }
            }
        }

        private void SWLaunchForm_Click(object sender, EventArgs e)
        {
            Assembly ensamblat = Assembly.LoadFrom($@"{this.Library}.dll");
            Object dllBD;
            Type tipus;

            tipus = ensamblat.GetType($"{this.Library}.{this.Form}");
            dllBD = Activator.CreateInstance(tipus);

            ((Form)dllBD).Show();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            SWLaunchForm_Click(sender, e);
        }

        private void lblTextBtn_Click(object sender, EventArgs e)
        {
            SWLaunchForm_Click(sender, e);
        }
    }
}
