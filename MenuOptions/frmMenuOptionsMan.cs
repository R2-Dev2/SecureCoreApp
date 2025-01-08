using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainForms;
using Utils;

namespace MenuOptions
{
    public partial class frmMenuOptionsMan : frmBase
    {
        public frmMenuOptionsMan()
        {
            InitializeComponent();
            this.title = "Menu Options Management";
            this.tableName = "UserOptions";
            this.codeTable = "description";
            swtxtImage.Leave += new System.EventHandler(this.LeaveImage);
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idOption"].Visible = false;
            dtgDades.Columns["description"].HeaderText = "Description";
            dtgDades.Columns["image"].Visible = false;
            dtgDades.Columns["formName"].HeaderText = "Form Name";
            dtgDades.Columns["tableName"].HeaderText = "Table Name";
            dtgDades.Columns["rangeOption"].HeaderText = "Access Level";
            dtgDades.Columns["namespace"].HeaderText = "Namespace";
            LoadImage();
        }

        private void LeaveImage(object sender, EventArgs e)
        {
            swtxtImage.SWTextbox_Leave(sender, e);
            LoadImage();
        }

        private void LoadImage()
        {
            Image img = ImageUtils.GetImageFromRelativePath(swtxtImage.Text);

            if (img != null)
            {
                pbImage.Image = img;
            }
            else
            {
                pbImage.Image = pbImage.ErrorImage;
            }
        }

        protected override void dtgDades_SelectionChanged(object sender, EventArgs e)
        {
            base.dtgDades_SelectionChanged(sender, e);
            LoadImage();
        }

    }
}
