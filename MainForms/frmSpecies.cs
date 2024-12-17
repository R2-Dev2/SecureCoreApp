using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class frmSpecies : frmBase
    {

        public frmSpecies()
        {
            InitializeComponent();
            this.Title = "Species";
            this.tableName = "Species";
            this.codeTable = "CodeSpecie";
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idSpecie"].Visible = false;
            dtgDades.Columns["CodeSpecie"].HeaderText = "Codi";
            dtgDades.Columns["DescSpecie"].HeaderText = "Descripció";
        }
    }
}
