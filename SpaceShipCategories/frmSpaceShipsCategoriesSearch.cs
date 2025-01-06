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

namespace SpaceShipCategories
{
    public partial class frmSpaceShipsCategoriesSearch : frmSearch
    {
        public frmSpaceShipsCategoriesSearch(string controlId, Form originalForm)
        {
            InitializeComponent();
            this.title = "SpaceShips Categories Search";
            this.tableName = "SpaceShipCategories";
            this.controlId = controlId;
            this.originalForm = originalForm;
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idSpaceShipCategory"].Visible = false;
            dtgDades.Columns["CodeSpaceShipCategory"].HeaderText = "Code";
            dtgDades.Columns["DescSpaceShipCategory"].HeaderText = "Description";
        }
    }
}
