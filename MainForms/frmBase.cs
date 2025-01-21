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
        protected AccesADades accesADades;
        protected DataSet dts;

        protected string connectionString;
        protected string tableName;
        protected string query;
        protected string codeTable;

        private bool isNewRow = false;
        private bool isRowAdded = false;
        private bool isBinded = false;
        private bool shouldValidate = true;
        private int incorrectRowIndex = -1;

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

        public frmBase()
        {
            InitializeComponent();
        }

        protected virtual void ConfigurarDataGrid()
        {
            dtgDades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDades.RowHeadersVisible = false;
        }

        private void BindDades()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SWTextBox swTxt)
                {
                    swTxt.DataBindings.Clear();
                    swTxt.DataBindings.Add("Text", dts.Tables[0], swTxt.columnName);
                    swTxt.Validated += new EventHandler(this.ValidateTextBox);
                }
            }
            isBinded = true;
        }

        private void ClearBindings()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SWTextBox swTxt)
                {
                    swTxt.DataBindings.Clear();

                    swTxt.Text = "";
                    
                    swTxt.Validated -= new EventHandler(this.ValidateTextBox);
                }
            }
            isBinded = false;
        }
        private void ValidateTextBox(object sender, EventArgs e)
        {
            if (isBinded)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        private bool ValidateAllControls(EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SWTextBox swTextBox)
                {
                    ValidateTextBox(swTextBox, e);
                    if (swTextBox.required && string.IsNullOrEmpty(swTextBox.Text))
                    {
                        lblError.Visible = true;
                        return false;
                    }
                }
            }
            lblError.Visible = false;
            return true;
        }

        private void AddNewRow(EventArgs e)
        {
            isNewRow = false;
            if (!ValidateAllControls(e)) return;

            DataRow row = dts.Tables[0].NewRow();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SWTextBox swTxt)
                {
                    if(swTxt.dadaPermesa == SWTextBox.TipusDada.Nombre)
                    {
                        row[swTxt.columnName] = int.Parse(swTxt.Text);
                    }
                    else
                    {
                        row[swTxt.columnName] = swTxt.Text;
                    }
                }
            }

            dts.Tables[tableName.ToString()].Rows.Add(row);
        }

        private void PortarDades()
        {
            dts = accesADades.PortarTaula(tableName);
            dtgDades.RowValidating -= this.dtgDades_RowValidating;

            try
            {
                dtgDades.DataSource = dts.Tables[tableName];
            }
            finally
            {
                dtgDades.RowValidating += this.dtgDades_RowValidating;
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

        protected bool SaveChanges(EventArgs e)
        {
            bool isSaved = true;
            if (!ValidateAllControls(e))
            {
                return false;
            }

            if (isNewRow)
            {
                AddNewRow(e);
            }

            int updatedRows = accesADades.Actualitzar(query, dts);

            if (updatedRows == -1)
            {
                ShowSaveLabel(false, "Couldn't save changes");
                PortarDades();
                isSaved = false;
            }
            else
            {
                if (updatedRows == 0)
                {
                    ShowSaveLabel(true, "No changes to save");
                }
                else
                {
                    ShowSaveLabel(true, $"Changes to {updatedRows} entries saved");
                }
            }

            if (isRowAdded)
            {
                PortarDades();
                BindDades();
                isRowAdded = false;
            }

            return isSaved;
        }

        private void ShowSaveLabel(bool isSuccessful, string message)
        {
            if (isSuccessful)
            {
                lblSave.Text = message;
                lblSave.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblSave.Text = message;
                lblSave.ForeColor = Color.Red;
            }
            lblSave.Visible = true;
            Task.Delay(3000).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() => { lblSave.Visible = false; }));
            });
        }

        private void frmAccesDades_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            this.connectionString = "SecureCore";
            this.accesADades = new AccesADades(this.connectionString);
            this.query = $"SELECT * FROM {this.tableName}";

            PortarDades();
            ConfigurarDataGrid();
            FocusOnCodeTable();
        }

        private void btnDesar_Click(object sender, EventArgs e)
        {
            SaveChanges(e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!ValidateAllControls(e))
            {
                return;
            }

            if (isNewRow)
            {
                AddNewRow(e);
            }

            ClearBindings();

            isNewRow = true;
            isRowAdded = true;

            FocusOnCodeTable();
        }

        protected virtual void dtgDades_SelectionChanged(object sender, EventArgs e)
        {
            if(incorrectRowIndex != -1)
            {
                shouldValidate = false;
                dtgDades.Rows[incorrectRowIndex].Selected = true;
                dtgDades.CurrentCell = dtgDades.Rows[incorrectRowIndex].Cells[1];
            }
            shouldValidate = true;
            if (isNewRow)
            {
                AddNewRow(e);
                BindDades();
            }
        }

        private void dtgDades_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!shouldValidate) return;
            if (!ValidateAllControls(e))
            {
                incorrectRowIndex = e.RowIndex;
            }
            else
            {
                incorrectRowIndex = -1;
                if (!isBinded && !isNewRow)
                {
                    dtgDades.ClearSelection();
                    dtgDades.Rows[e.RowIndex].Selected = true;
                    dtgDades.CurrentCell = dtgDades.Rows[e.RowIndex].Cells[1];
                    BindDades();
                    ValidateAllControls(e);
                }
            }
        }
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgDades_CurrentCellChanged(object sender, EventArgs e)
        {
            if (incorrectRowIndex == -1)
            {
                dtgDades_SelectionChanged(sender, e);
            }
        }
    }
}
