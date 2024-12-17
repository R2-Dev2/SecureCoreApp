using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using CustomControls;

namespace MainForms
{
    public partial class frmSearch : Form
    {
        private AccesADades accesADades;
        private DataSet dts;
        private Dictionary<string, string> dict = new Dictionary<string, string>(); 

        protected string connectionString;
        protected string tableName;

        private string _title;

        public string title
        {
            get { return _title; }
            set
            {
                _title = value;
                lblTitle.Text = _title;
                lblTitle.Refresh();
            }
        }

        private DataRow _selectedValue;

        public DataRow selectedValue
        {
            get { return _selectedValue; }
            set { _selectedValue = value; }
        }

        public frmSearch()
        {
            InitializeComponent();
        }

        protected virtual void ConfigurarDataGrid()
        {
            dtgDades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDades.RowHeadersVisible = false;
        }

        private void PortarDades()
        {
            dts = accesADades.ExecutaCerca(tableName, dict);
            dtgDades.DataSource = dts.Tables[0];
            ConfigurarDataGrid();
        }

        private void PortarDadesInicials()
        {
            string query = $"SELECT * FROM {this.tableName} WHERE 1 = 2";
            dts = accesADades.PortarPerConsulta(query);
            dtgDades.DataSource = dts.Tables[0];
            ConfigurarDataGrid();
        }

        private void FillDictionary()
        {
            dict.Clear();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SWTextBox)
                {
                    SWTextBox swTxt = (SWTextBox)ctrl;
                    if (!string.IsNullOrEmpty(swTxt.Text))
                    {
                        dict.Add(swTxt.columnName, swTxt.Text);
                    }
                }
                //TODO afegir gestió SWCodi
            }
        }

        private void selectAndClose()
        {
            if(dts != null)
            {
                selectedValue = dts.Tables[0].Rows[dtgDades.CurrentRow.Index];
            }
            this.Close();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            this.connectionString = "SecureCore";
            this.accesADades = new AccesADades(this.connectionString);
            PortarDadesInicials();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillDictionary();
            PortarDades();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectAndClose();
        }

        private void dtgDades_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectAndClose();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            dts = null;
            this.Close();
        }
    }
}
