﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainForms;

namespace Planets
{
    public partial class frmSpaceShipTypesSearch : frmSearch
    {
        public frmSpaceShipTypesSearch(string controlId, Form originalForm)
        {
            InitializeComponent();
            this.tableName = "SpaceShipTypes";
            this.title = "Search SpaceShip Types";
            this.controlId = controlId;
            this.originalForm = originalForm;
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idSpaceShipType"].Visible = false;
            dtgDades.Columns["CodeSpaceShipType"].HeaderText = "Code";
            dtgDades.Columns["DescSpaceShipType"].HeaderText = "Description";
            dtgDades.Columns["idFiliation"].Visible = false;
            dtgDades.Columns["idSpaceShipCategory"].Visible = false;
        }
    }
}
