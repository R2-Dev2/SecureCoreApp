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
    public partial class frmSpaceShipsTypesMant : frmBase
    {
        public frmSpaceShipsTypesMant()
        {
            InitializeComponent();
            this.title = "SpaceShip Types Management";
            this.tableName = "SpaceShipTypes";
            this.codeTable = "CodeSpaceShipType";
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idSpaceShipType"].Visible = false;
            dtgDades.Columns["idFiliation"].Visible = false;
            dtgDades.Columns["idSpaceShipCategory"].Visible = false;
            dtgDades.Columns["CodeSpaceShipType"].HeaderText = "Code";
            dtgDades.Columns["DescSpaceShipType"].HeaderText = "Description";
        }
    }
}
