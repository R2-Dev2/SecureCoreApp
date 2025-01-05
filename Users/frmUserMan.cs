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

namespace Users
{
    public partial class frmUserMan : frmBase
    {
        public frmUserMan()
        {
            InitializeComponent();
            this.title = "Users Management";
            this.tableName = "Users SpaceShipTypes";
            this.codeTable = "CodeUser";
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idUser"].Visible = false;
            dtgDades.Columns["idUserRank"].Visible = false;
            dtgDades.Columns["idUserCategory"].Visible = false;
            dtgDades.Columns["CodeUser"].HeaderText = "Code";
            dtgDades.Columns["UserName"].HeaderText = "User Name";
            dtgDades.Columns["Login"].Visible = false;
            dtgDades.Columns["Password"].Visible = false;
            dtgDades.Columns["Photo"].Visible = false;
            dtgDades.Columns["idPlanet"].Visible = false;
            dtgDades.Columns["idSpecie"].Visible = false;
            dtgDades.Columns["Salt"].Visible = false;
        }
    }
}

