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
using CustomControls;

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
        private bool isBinded = false;
        private int invalidRowIndex;

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
                if (ctrl is SWTextBox)
                {
                    SWTextBox swTxt = (SWTextBox)ctrl;
                    swTxt.DataBindings.Clear();
                    swTxt.DataBindings.Add("Text", dts.Tables[0], swTxt.columnName);
                    if (swTxt.isForeignKey)
                    {
                      //  swTxt.TextChanged += new EventHandler(this.ValidateTextBox);
                    }
                    swTxt.Validated += new EventHandler(this.ValidateTextBox);
                }
            }
            isBinded = true;
        }

        protected void ClearBindings(bool isNew)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SWTextBox)
                {
                    SWTextBox swTxt = (SWTextBox)ctrl;
                    swTxt.DataBindings.Clear();
                    if (isNew)
                    {
                        swTxt.Text = "";
                    }
                    swTxt.Validated -= new EventHandler(this.ValidateTextBox);
                }
            }
            isBinded = false;
        }
        protected void ValidateTextBox(object sender, EventArgs e)
        {
            if (isBinded)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        protected bool ValidateAllControls(EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is SWTextBox swTextBox)
                {
                    ValidateTextBox(swTextBox, e);
                    if (swTextBox.required && string.IsNullOrEmpty(swTextBox.Text))
                    {
                        lblError.Visible = true;
                       /// dtgDades.Enabled = false;
                        return false;
                    }
                }
            }
         //   dtgDades.Enabled = true;
            lblError.Visible = false;
            return true;
        }

        protected void AddNewRow()
        {
            isNewRow = false;

            DataRow row = dts.Tables[0].NewRow();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SWTextBox)
                {
                    SWTextBox swTxt = (SWTextBox)ctrl;
                    try
                    {
                        row[swTxt.columnName] = swTxt.Text;
                    }
                    catch (Exception)
                    {
                        row[swTxt.columnName] = int.Parse(swTxt.Text);
                    }
                }
            }

            dts.Tables[tableName.ToString()].Rows.Add(row);
        }

        private void PortarDades()
        {
            dts = accesADades.PortarTaula(tableName);
            dtgDades.RowValidating -= dtgDades_RowValidating;
            try
            {
                dtgDades.DataSource = dts.Tables[tableName];
            }
            finally
            {
                dtgDades.RowValidating += dtgDades_RowValidating;
            }
            BindDades();
        }

        private void FocusOnCodeTable()
        {
            if (this.codeTable != null)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is SWTextBox swTextBox && swTextBox.columnName == codeTable)
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
            if (!validateRows(e))
            {
                return;
            }

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
            if (!ValidateAllControls(e))
            {
                ClearBindings(false);
                return;
            }

            if (isNewRow)
            {
                AddNewRow();
            }

            ClearBindings(true);

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
            //else if (!isBinded)
            //{
            //    BindDades();
            //}
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgDades_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (!ValidateAllControls(e))
            //{
            //    ClearBindings(false);
            //    dtgDades.CausesValidation = false;
            //    this.invalidRowIndex = e.RowIndex;
            //}
            //else
            //{
            //    if (!isBinded)
            //    {
            //        dtgDades.ClearSelection();
            //        dtgDades.Rows[e.RowIndex].Selected = true;
            //        BindDades();
            //        ValidateAllControls(e);
            //    }
            //}
            //dtgDades.CausesValidation = true;
        }

        private bool validateRows(EventArgs e)
        {
            foreach(DataGridViewRow dr in dtgDades.Rows)
            {
                int index = dr.Index;
                dtgDades.ClearSelection();
                dtgDades.Rows[index].Selected = true;
                //Como cambio los controles? ask guti :=)
                if (!ValidateAllControls(e))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
