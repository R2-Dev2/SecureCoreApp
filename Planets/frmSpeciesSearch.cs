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
    public partial class frmSpeciesSearch : frmSearch
    {
        public frmSpeciesSearch()
        {
            InitializeComponent();
            this.connectionString = "SecureCore";
            this.tableName = "Species";
            this.title = "Search Species";
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idSpecie"].Visible = false;
            dtgDades.Columns["CodeSpecie"].HeaderText = "Code";
            dtgDades.Columns["DescSpecie"].HeaderText = "Description";
        }
    }
}
