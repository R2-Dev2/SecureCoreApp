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

namespace Planets
{
    public partial class frmPlanetsSearch : frmSearch
    {
        public frmPlanetsSearch(string controlId, Form originalForm)
        {
            InitializeComponent();
            this.tableName = "Planets";
            this.title = "Search Planets";
            this.controlId = controlId;
            this.originalForm = originalForm;
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idPlanet"].Visible = false;
            dtgDades.Columns["idSector"].Visible = false;
            dtgDades.Columns["idNatives"].Visible = false;
            dtgDades.Columns["idFiliation"].Visible = false;
            dtgDades.Columns["CodePlanet"].HeaderText = "Code";
            dtgDades.Columns["DescPlanet"].HeaderText = "Description";
            dtgDades.Columns["long"].Visible = false;
            dtgDades.Columns["lat"].Visible = false;
            dtgDades.Columns["parsecs"].Visible = false;
            dtgDades.Columns["PlanetPicture"].Visible = false;
            dtgDades.Columns["IPPlanet"].Visible = false;
            dtgDades.Columns["PortPlanet"].Visible = false;
            dtgDades.Columns["PortPlanet1"].Visible = false;
        }
    }
}
