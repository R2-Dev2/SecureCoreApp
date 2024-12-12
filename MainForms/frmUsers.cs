using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class frmUsers : frmBase
    {
        public frmUsers()
        {
            InitializeComponent();
            this.Title = "Users";
            tableName = "Users";
            query = $"SELECT * FROM {tableName}";

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            dtgDades.Columns["idUser"].Visible = false;
            dtgDades.Columns["Salt"].Visible = false;
            dtgDades.Columns["idSpecie"].Visible = false;
            dtgDades.Columns["idPlanet"].Visible = false;
            dtgDades.Columns["idUserRank"].Visible = false;
            dtgDades.Columns["idUserCategory"].Visible = false;
            dtgDades.Columns["Password"].Visible = false;

            dtgDades.Columns["CodeUser"].HeaderText = "Code";
            dtgDades.Columns["UserName"].HeaderText = "User";
            dtgDades.Columns["Photo"].HeaderText = "Image";
        }
    }
}
