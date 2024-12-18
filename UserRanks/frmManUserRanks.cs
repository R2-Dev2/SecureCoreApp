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
    public partial class frmManUserRanks : frmBase
    {
        public frmManUserRanks()
        {
            InitializeComponent();
            this.Title = "User Ranks";
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
