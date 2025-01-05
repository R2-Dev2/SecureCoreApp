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

namespace UserCategories
{
    public partial class frmUserSearch : frmSearch
    {
        public frmUserSearch(string controlId, Form originalForm)
        {
            InitializeComponent();
            this.tableName = "Users";
            this.title = "Search Users";
            this.controlId = controlId;
            this.originalForm = originalForm;
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idUsers"].Visible = false;
            dtgDades.Columns["idUserRank"].Visible = false;
            dtgDades.Columns["idUserCategory"].Visible = false;
            dtgDades.Columns["idPlanet"].Visible = false;
            dtgDades.Columns["idSpecie"].Visible = false;
            dtgDades.Columns["CodeUser"].HeaderText = "Code";
            dtgDades.Columns["UserName"].HeaderText = "User Name";
            dtgDades.Columns["Login"].HeaderText = "Login";
            dtgDades.Columns["Photo"].Visible = false;
            dtgDades.Columns["Password"].Visible = false;
            dtgDades.Columns["Salt"].Visible = false;
        }
    }
}
