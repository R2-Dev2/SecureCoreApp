﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using DataAccess;
using Utils;

namespace Users
{
    public partial class frmUserProfile : Form
    {
        private AccesADades accesADades;
        private DataSet dts;

        private string connectionString;
        private string query;
        
        private string idUser;

        public frmUserProfile(string idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
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
            pbProfile.DataBindings.Add("Image", dts.Tables[0], "Photo", true);
        }

        private void ValidateTextBox(object sender, EventArgs e)
        {
             ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void EndImageEdit()
        {
            this.pbProfile.DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void LoadImage()
        {
            Image img = ImageUtils.GetImageFromDataBase(dts.Tables[0].Rows[0]["Photo"]);
            
            if(img != null)
            {
                pbProfile.Image = img;
                EndImageEdit();
            }
            else
            {
                pbProfile.Image = pbProfile.ErrorImage;
            };
        }

        private void ChooseImageFromFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.png;*.jpg|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                pbProfile.Image = new Bitmap(openFileDialog.FileName);
                Image logo = Image.FromFile(filename);
                pbProfile.Image = logo;
                EndImageEdit();
            }
            else
            {
                LoadImage();
            }
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            this.connectionString = "SecureCore";
            this.accesADades = new AccesADades(this.connectionString);
            this.query = $"SELECT * FROM users WHERE idUser = '{this.idUser}'";
            dts = accesADades.PortarPerConsulta(query);
            BindDades();
        }        

        private void btnSave_Click(object sender, EventArgs e)
        {
           accesADades.Actualitzar(query, dts);
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            ChooseImageFromFile();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
