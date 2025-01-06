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

namespace Sectors
{
    public partial class frmSectorsSearch : frmSearch
    {
        public frmSectorsSearch(string controlId, Form originalForm)
        {
            InitializeComponent();
            this.title = "Sectors Planets Search";
            this.tableName = "Sectors";
            this.controlId = controlId;
            this.originalForm = originalForm;
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idSector"].Visible = false;
            dtgDades.Columns["idRegion"].Visible = false;
            dtgDades.Columns["CodeSector"].HeaderText = "Code";
            dtgDades.Columns["DescSector"].HeaderText = "Description";
        }
    }
}
