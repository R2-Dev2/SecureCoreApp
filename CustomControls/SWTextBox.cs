using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CustomControls
{
    class SWTextBox : TextBox
    {
        public SWTextBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextbox
            // 
            this.Enter += new System.EventHandler(this.SWTextbox_Enter);
            this.Leave += new System.EventHandler(this.SWTextbox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWTextbox_Validating);
            this.Validated += new System.EventHandler(this.SWTextbox_Validated);
            this.ResumeLayout(false);
        }
        public enum TipusDada
        {
            Nombre,
            Text,
            Codi
        }
        private TipusDada _DadaPermesa;
        public TipusDada DadaPermesa
        {
            get { return _DadaPermesa; }
            set
            {
                _DadaPermesa = value;
            }
        }

        private bool _OpcionalitatDada;
        public bool OpcionalDada
        {
            get { return _OpcionalitatDada; }
            set { _OpcionalitatDada = value; }
        }

        private string _NomControl;
        public string NomControl
        {
            get { return _NomControl; }
            set { _NomControl = value; }
        }

        private bool _EsForeignKey;
        public bool EsClauForana
        {
            get { return _EsForeignKey; }
            set { _EsForeignKey = value; }
        }


        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }

        private void SWTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool validacio = false;

            if (this.DadaPermesa == TipusDada.Nombre)
            {
                Regex nombre = new Regex(@"^\d+$");
                if (nombre.IsMatch(this.Text))
                {
                    validacio = true;
                }
            }
            else if (this.DadaPermesa == TipusDada.Codi)
            {
                Regex text = new Regex(@"^[A-Z^AEIOU]{4}-\d{3}/[13579]{1}[AEIOU]{1}$");
                if (text.IsMatch(this.Text))
                {
                    validacio = true;
                }
            }
            else
            {
                validacio = true;
            }

            if (!validacio)
            {
                this.Clear();
            }
        }

        private void SWTextbox_Validated(object sender, EventArgs e)
        {
            if (NomControl != null)
            {
                Form frm = this.FindForm();
                foreach (Control ctr in frm.Controls)
                {
                    if (ctr is TextBox)
                    {
                        TextBox txtBox = (TextBox)ctr;

                        if (txtBox.Name == NomControl)
                        {
                            txtBox.Text = this.Text;
                        }
                    }
                }
            }
        }
    }
}
