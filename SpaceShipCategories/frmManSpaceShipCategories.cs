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
using CustomControls;

namespace SpaceShipCategories
{
    public partial class frmManSpaceShipCategories : frmBase
    {
        public frmManSpaceShipCategories()
        {
            InitializeComponent();
            this.Title = "SpaceShip Categories";
            this.tableName = "SpaceShipCategories";
            this.codeTable = "CodeSpaceShipCategory";
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
