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

        public frmFactoriesMan()
        {
            InitializeComponent();
        }

        private void FerBinding()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.DataBindings.Clear();
                    ctrl.DataBindings.Add("Text", factory, ctrl.Tag.ToString());
                }
            }
        }

        private void TreureBinding()
        {
            txtCode.DataBindings.Clear();
            txtCode.Clear();
            txtDesc.DataBindings.Clear();
            txtDesc.Clear();
        }

        private void CarregarDades()
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
            FerBinding();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EsNou = true;
            TreureBinding();
            txtCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EsNou)
            {
                Factory agency = new Factory
                {
                    codeFactory = txtCode.Text,
                    DescFactory = txtDesc.Text,
                };
                db.Factories.Add(agency);
            }
            db.SaveChanges();
            CarregarDades();
        }

        private void dtgFactories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dtgFactories.SelectedRows.Count == 1)
            {
                int valor = Int32.Parse(dtgFactories.SelectedRows[0].Cells["idFactory"].Value.ToString());
                var proDel = db.Factories.FirstOrDefault(x => x.idFactory == valor);
                db.Factories.Remove(proDel);
            }
            db.SaveChanges();
            CarregarDades();
        }

        private void frmFactoriesMan_Load(object sender, EventArgs e)
        {
            CarregarDades();
        }
    }
}
