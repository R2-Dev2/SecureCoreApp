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

namespace UserRanks
{
    public partial class frmUserRanksMan : frmBase
    {
        public frmUserRanksMan()
        {
            InitializeComponent();
            this.title = "User Ranks Management";
            this.tableName = "UserRanks";
            this.codeTable = "CodeRank";
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idUserRank"].Visible = false;
            dtgDades.Columns["CodeRank"].HeaderText = "Code";
            dtgDades.Columns["DescRank"].HeaderText = "Description";
        }
    }
}
