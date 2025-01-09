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
    public partial class frmUserCategoriesMan : frmBase
    {
        public frmUserCategoriesMan()
        {
            InitializeComponent();
            this.title = "User Categories Management";
            this.tableName = "UserCategories";
            this.codeTable = "CodeCategory";
        }

        private void frmuserCategories_Load(object sender, EventArgs e)
        {
            dtgDades.Columns["idUserCategory"].Visible = false;
            dtgDades.Columns["CodeCategory"].HeaderText = "Code";
            dtgDades.Columns["DescCategory"].HeaderText = "Description";
            dtgDades.Columns["AccessLevel"].HeaderText = "Access Level";
        }
    }
}
