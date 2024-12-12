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
    public partial class frmUserCategories : frmBase
    {
        public frmUserCategories()
        {
            InitializeComponent();
            this.Title = "User Categories";
            tableName = "UserCategories";
            query = $"SELECT * FROM {tableName}";

        }

        private void frmUserCategories_Load(object sender, EventArgs e)
        {
            dtgDades.Columns["idUserCategory"].Visible = false;
            dtgDades.Columns["CodeCategory"].HeaderText = "Category";
            dtgDades.Columns["DescCategory"].HeaderText = "Description";
            dtgDades.Columns["AccessLevel"].HeaderText = "Access Level";
        }
    }
}
