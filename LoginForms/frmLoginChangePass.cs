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
using System.Security.Cryptography;
using DataAccess;
using MainForms;
using Utils;

namespace LoginForms
{
    public partial class frmLoginChangePass : Form
    {
        private AccesADades accesADades;
        private DataSet dts;
        private string tableName = "Users";
        private string password;
        private string _idUser;
        private string query;

        public string idUser
        {
            get => _idUser;
            set => _idUser = value;
        }

        public frmLoginChangePass()
        {
            InitializeComponent();
        }

        private void frmLoginChangePass_Load(object sender, EventArgs e)
        {
            this.accesADades = new AccesADades("SecureCore");
            PortarDades();
        }

        private void PortarDades()
        {
            query= $"SELECT idUser, Password, Salt FROM {this.tableName} WHERE idUser = '{idUser}'";

            dts = accesADades.PortarPerConsulta(query);
        }

        private void ActualitzarContrasenya(string novaContrasenya)
        {
            if(this.dts.Tables[0].Rows.Count == 1)
            {
                byte[] salt = HashingUtils.GenerateSalt();
                byte[] hashedPassword = HashingUtils.ComputeHash(password, salt);
                this.dts.Tables[0].Rows[0]["Salt"] = BitConverter.ToString(salt);
                this.dts.Tables[0].Rows[0]["Password"] = BitConverter.ToString(hashedPassword);
                accesADades.Actualitzar(this.query, dts);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPwd.Text) || string.IsNullOrWhiteSpace(txtPasswordValidacio.Text))
            {
                lblIncorrect.Visible = true;
            }
            else if (txtPwd.Text == txtPasswordValidacio.Text)
            {
                password = txtPwd.Text;

                ActualitzarContrasenya(password);

                this.Close();
            }
            else
            {
                lblIncorrect.Visible = true;
            }
        }
    }
}
