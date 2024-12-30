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
    public partial class frmUserRankSearch : frmSearch
    {
        public frmUserRankSearch(string controlId, Form originalForm)
        {
            InitializeComponent();
            this.tableName = "UserRanks";
            this.title = "Search User Ranks";
            this.controlId = controlId;
            this.originalForm = originalForm;
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
