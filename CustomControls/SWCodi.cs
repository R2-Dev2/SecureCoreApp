using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class SWCodi : UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
        }



        private string nomTaula;
        public string NomTaula
        {
            get { return nomTaula; }
            set { nomTaula = value; }
        }

        private string nomCodi;
        public string NomCodi
        {
            get { return nomCodi; }
            set { nomCodi = value; }
        }

        private string nomDesc;
        public string NomDesc
        {
            get { return nomDesc; }
            set { nomDesc = value; }
        }

        private string nomId;
        public string NomId
        {
            get { return nomId; }
            set { nomId = value; }
        }

        private string controlId;
        public string ControlId
        {
            get { return controlId; }
            set { controlId = value; }
        }

        private string formCS;
        public string FormCs
        {
            get { return formCS; }
            set { formCS = value; }
        }

        private string classeCS;
        public string ClasseCS
        {
            get { return classeCS; }
            set { classeCS = value; }
        }

        private void Validacodi()
        {
            
        }
        private void ObreCS()
        {

        }
    }
}
