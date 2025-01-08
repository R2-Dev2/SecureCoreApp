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

namespace Planets
{
    public partial class frmPlanetsMan : frmBase
    {
        public frmPlanetsMan()
        {
            InitializeComponent();
            this.title = "Planets Management";
            this.tableName = "Planets";
            this.codeTable = "CodePlanet";
            swImagePlan.Leave += new System.EventHandler(this.LeaveImage);
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idPlanet"].Visible = false;
            dtgDades.Columns["idSector"].Visible = false;
            dtgDades.Columns["idNatives"].Visible = false;
            dtgDades.Columns["idFiliation"].Visible = false;
            dtgDades.Columns["PlanetPicture"].Visible = false;
            dtgDades.Columns["CodePlanet"].HeaderText = "Code";
            dtgDades.Columns["DescPlanet"].HeaderText = "Description";
            dtgDades.Columns["long"].HeaderText = "Long";
            dtgDades.Columns["lat"].HeaderText = "Lat";
            dtgDades.Columns["parsecs"].HeaderText = "Parsecs";
            dtgDades.Columns["PortPlanet"].HeaderText = "Port Planet";
            dtgDades.Columns["PortPlanet1"].HeaderText = "Port Planet1";
            dtgDades.Columns["IPPlanet"].HeaderText = "IP Planet";
            LoadImage();
        }

        private void LeaveImage(object sender, EventArgs e)
        {
            swImagePlan.SWTextbox_Leave(sender, e);
            LoadImage();
        }

        private void LoadImage()
        {
            Image img = ImageUtils.GetImageFromUrl(swImagePlan.Text);
            if (img is null)
            {
                img = pbPlanet.ErrorImage;
            }
            pbPlanet.Image = img;
        }

        protected override void dtgDades_SelectionChanged(object sender, EventArgs e)
        {
            base.dtgDades_SelectionChanged(sender, e);
            LoadImage();
        }
    }
}
