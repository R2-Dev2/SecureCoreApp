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
    public partial class frmUserCategoriesSearch : frmSearch
    {
        public frmUserCategoriesSearch(string controlId, Form originalForm)
        {
            InitializeComponent();
            this.tableName = "UserCategories";
            this.title = "Search User Categories";
            this.controlId = controlId;
            this.originalForm = originalForm;
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idUserCategory"].Visible = false;
            dtgDades.Columns["CodeCategory"].HeaderText = "Code";
            dtgDades.Columns["DescCategory"].HeaderText = "Description";
            dtgDades.Columns["AccessLevel"].Visible = false;
        }
    }
}
