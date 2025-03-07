using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Factories
{
    public partial class frmFactoriesMan : Form
    {
        private SecureCoreG7Entities db;
        private List<Factory> factory;
        private bool EsNou = false;
        private Factory factorySeleccionada;

        public frmFactoriesMan()
        {
            InitializeComponent();
        }

        private void RemoveBinding()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        private void LoadData()
        {
            db = new SecureCoreG7Entities();
            factory = db.Factories.ToList();
            dtgFactories.DataSource = factory;
            ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            dtgFactories.Refresh();
            dtgFactories.Update();
            dtgFactories.Columns["idFactory"].Visible = false;
            dtgFactories.Columns["codeFactory"].HeaderText = "Code";
            dtgFactories.Columns["DescFactory"].HeaderText = "Description";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCode.Text))
            {
                btnSave_Click(sender, e);
            }
            EsNou = true;
            RemoveBinding();
            txtCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
            else if (factorySeleccionada != null)
            {
                factorySeleccionada.codeFactory = txtCode.Text;
                factorySeleccionada.DescFactory = txtDesc.Text;
                db.Entry(factorySeleccionada).State = EntityState.Modified;
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
                    int id = Convert.ToInt32(row.Cells["idFactory"].Value);
                    var proDel = db.Factories.FirstOrDefault(x => x.idFactory == id);
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
        }

        private void dtgFactories_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgFactories.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dtgFactories.SelectedRows[0].Cells["idFactory"].Value);
                factorySeleccionada = db.Factories.FirstOrDefault(f => f.idFactory == id);
                if (factorySeleccionada != null)
                {
                    txtCode.Text = factorySeleccionada.codeFactory;
                    txtDesc.Text = factorySeleccionada.DescFactory;
                }
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
