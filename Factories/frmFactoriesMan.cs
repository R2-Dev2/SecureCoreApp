using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.IO;

namespace Factories
{
    public partial class frmFactoriesMan : Form
    {
        SecureCoreG7Entities db;
        List<Factory> factory;
        protected string codeTable;
        bool EsNou = false;
        private Factory factorySeleccionada;
        private Factory factoryAnterior;

        public frmFactoriesMan()
        {
            InitializeComponent();
        }

        private void RemoveBinding()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox swTextBox)
                {
                    swTextBox.Clear();
                }
            }
        }

        private void LoadData()
        {
            db = new SecureCoreG7Entities();

            factory = db.Factories.ToList();

            dtgFactories.DataSource = factory;
            dtgFactories.Refresh();
            dtgFactories.Update();
            dtgFactories.Columns["idFactory"].Visible = false;
            dtgFactories.Columns["codeFactory"].Visible = true;
            dtgFactories.Columns["DescFactory"].Visible = true;

            dtgFactories.Refresh();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (factorySeleccionada != null)
            {
                factoryAnterior = new Factory
                {
                    codeFactory = factorySeleccionada.codeFactory,
                    DescFactory = factorySeleccionada.DescFactory
                };
            }

            EsNou = true;
            RemoveBinding();
            txtCode.Focus();
        }

        private bool ValidateAllControls()
        {
            bool isValid = true;
            lblError.Visible = false;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox textBox) 
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        lblError.Visible = true;
                        isValid = false;
                    }
                }
            }
            return isValid;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Comprovar si txtCode està buit
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                lblError.Visible = true;
                return;
            }

            if (EsNou)
            {
                factorySeleccionada = new Factory
                {
                    codeFactory = txtCode.Text,
                    DescFactory = txtDesc.Text,
                };
                db.Factories.Add(factorySeleccionada);
            }
            else
            {
                if (factorySeleccionada != null)
                {
                    factorySeleccionada.codeFactory = txtCode.Text;
                    factorySeleccionada.DescFactory = txtDesc.Text;
                    db.Entry(factorySeleccionada).State = EntityState.Modified;
                }
            }

            db.SaveChanges();

            LoadData();
            EsNou = false;
        }

        private void dtgFactories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dtgFactories.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgFactories.SelectedRows)
                {
                    int valor = Convert.ToInt32(row.Cells["idFactory"].Value);
                    var proDel = db.Factories.FirstOrDefault(x => x.idFactory == valor);

                    if (proDel != null)
                    {
                        db.Factories.Remove(proDel);  
                    }
                }

                db.SaveChanges();
                LoadData();
            }
        }

        private void frmFactoriesMan_Load(object sender, EventArgs e)
        {
            LoadData();
            dtgFactories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dtgFactories_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgFactories.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgFactories.SelectedRows[0];

                int idFactory = Convert.ToInt32(selectedRow.Cells["idFactory"].Value);

                factorySeleccionada = db.Factories.FirstOrDefault(f => f.idFactory == idFactory);

                if (factorySeleccionada != null)
                {
                    txtCode.Text = factorySeleccionada.codeFactory;
                    txtDesc.Text = factorySeleccionada.DescFactory;
                }
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
