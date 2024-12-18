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

namespace SpaceShipsTypes
{
    public partial class frmFiliationsSearch : frmSearch
    {
        public frmFiliationsSearch(string controlId, Form originalForm)
        {
            InitializeComponent();
            this.title = "Filiations Search";
            this.tableName = "Filiations";
            this.controlId = controlId;
            this.originalForm = originalForm;
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idFiliation"].Visible = false;
            dtgDades.Columns["CodeFiliation"].HeaderText = "Code";
            dtgDades.Columns["DescFiliations"].HeaderText = "Description";
        }

    }
}
