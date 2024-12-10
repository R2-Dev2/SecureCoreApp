using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccess;

namespace MainForms
{
    public partial class frmBase : Form
    {
        private AccesADades accesADades;
        private DataSet dts;

        protected string connectionString;
        protected string tableName;
        protected string query;
        protected string codeTable;

        private bool isNewRow = false;
        private bool isRowAdded = false;

        private string title;

        public string Title
        {
            get { return title; }
            set { 
                title = value;
                lblTitle.Text = title;
                lblTitle.Refresh();
            }
        }


        public frmBase()
        {
            InitializeComponent();
        }

        protected virtual void ConfigurarDataGrid()
        {
            dtgDades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDades.RowHeadersVisible = false;
        }


        protected void BindDades()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.DataBindings.Clear();
                    ctrl.DataBindings.Add("Text", dts.Tables[0], ctrl.Tag.ToString());
                    ctrl.Validated += new EventHandler(this.ValidateTextBox);
                }
            }
        }

        protected void ClearBindings()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.DataBindings.Clear();
                    ctrl.Text = "";
                    ctrl.Validated -= new EventHandler(this.ValidateTextBox);
                }
            }
        }
        protected void ValidateTextBox(object sender, EventArgs e)
        {
            if (!isNewRow)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        protected void ValidateComboBox(object sender, EventArgs e)
        {
            if (!isNewRow)
            {
                ((ComboBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        protected void AddNewRow()
        {
            isNewRow = false;

            DataRow row = dts.Tables[0].NewRow();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    row[ctrl.Tag.ToString()] = ctrl.Text;
                }
            }

            dts.Tables[tableName.ToString()].Rows.Add(row);
        }

        private void PortarDades()
        {
            dts = accesADades.PortarTaula(tableName);
            dtgDades.DataSource = dts.Tables[tableName];
            BindDades();
        }

        private void FocusOnCodeTable()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl.Tag != null)
                {
                    if (ctrl.Tag.ToString().Equals(codeTable))
                    {
                        ctrl.Focus();
                        return;
                    }
                }
            }
        }

        private void frmAccesDades_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            this.connectionString = "SecureCore";
            this.accesADades = new AccesADades(this.connectionString);
            this.query = $"SELECT * FROM {this.tableName}";

            PortarDades();
            ConfigurarDataGrid();
        }

        private void btnDesar_Click(object sender, EventArgs e)
        {
            if (isNewRow)
            {
                AddNewRow();
            }

            accesADades.Actualitzar(query, dts);

            if (isRowAdded)
            {
                PortarDades();
                BindDades();
                isRowAdded = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (isNewRow)
            {
                AddNewRow();
            }

            ClearBindings();

            isNewRow = true;
            isRowAdded = true;

            FocusOnCodeTable();
        }

        private void dtgSpecies_SelectionChanged(object sender, EventArgs e)
        {
            if (isNewRow)
            {
                AddNewRow();
                BindDades();
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
