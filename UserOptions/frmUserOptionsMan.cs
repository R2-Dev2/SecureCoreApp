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

namespace UserOptions
{
    public partial class frmUserOptionsMan : frmBase
    {
        public frmUserOptionsMan()
        {
            this.title = "User Options Management";
            this.tableName = "UserOptions";
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idOption"].Visible = false;
            dtgDades.Columns["description"].HeaderText = "Description";
            dtgDades.Columns["image"].Visible = false;
            dtgDades.Columns["formName"].HeaderText = "FormName";
            dtgDades.Columns["tableName"].HeaderText = "TableName";
            dtgDades.Columns["rangeOption"].HeaderText = "RangeOption";
            dtgDades.Columns["namespace"].HeaderText = "Namespace";
        }
    }
}
