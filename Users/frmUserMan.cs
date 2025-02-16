﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MainForms;

namespace Users
{
    public partial class frmUserMan : frmBase
    {
        private ReportDocument cryRpt;
        public frmUserMan()
        {
            InitializeComponent();
            this.title = "Users Management";
            this.tableName = "Users";
            this.codeTable = "CodeUser";
        }
        protected override void ConfigurarDataGrid()
        {
            base.ConfigurarDataGrid();
            dtgDades.Columns["idUser"].Visible = false;
            dtgDades.Columns["idUserRank"].Visible = false;
            dtgDades.Columns["idUserCategory"].Visible = false;
            dtgDades.Columns["CodeUser"].HeaderText = "Code";
            dtgDades.Columns["UserName"].HeaderText = "Name";
            dtgDades.Columns["Login"].HeaderText = "Username";
            dtgDades.Columns["Password"].Visible = false;
            dtgDades.Columns["Photo"].Visible = false;
            dtgDades.Columns["idPlanet"].Visible = false;
            dtgDades.Columns["idSpecie"].Visible = false;
            dtgDades.Columns["Salt"].Visible = false;
        }

        private void SetCredentialsInfo()
        {
            SqlConnectionStringBuilder builder = accesADades.GetStringConnectionBuilder();

            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            crConnectionInfo.ServerName = builder.DataSource;
            crConnectionInfo.DatabaseName = builder.InitialCatalog;
            crConnectionInfo.UserID = builder.UserID;
            crConnectionInfo.Password = builder.Password;

            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            Tables CrTables = cryRpt.Database.Tables;

            foreach (Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            string printer = "Microsoft to PDF";
            foreach(string str in PrinterSettings.InstalledPrinters)
            {
                if(str.ToUpper().Contains(" PDF"))
                {
                    printer = str;
                    break;
                }
            }
            try
            {
                cryRpt.PrintOptions.PrinterName = printer;
                PrinterSettings settings = new PrinterSettings();
                settings.PrintFileName = "Access_Cards";
                cryRpt.PrintToPrinter(1, false, 0, 0);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't find PDF printer");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            cryRpt = new ReportDocument();
            cryRpt.Load("AccessCardsReport.rpt");
            SetCredentialsInfo();
            string id = dtgDades.SelectedRows[0].Cells[0].Value.ToString();
            
            cryRpt.RecordSelectionFormula = "{Users.idUser} = " + Convert.ToInt32(id);

            crvAccessCards.ReportSource = cryRpt;
            crvAccessCards.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None; 

            crvAccessCards.Refresh();
        }
        
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string message = "Couldn't reset password";
            if (SaveChanges(e))
            {
                dtgDades.SelectedRows[0].Cells["Salt"].Value = null;
                dtgDades.SelectedRows[0].Cells["Password"].Value = "12345aA";
                if (accesADades.Actualitzar(this.query, dts) > 0)
                {
                    message = "Password reseted to default";
                }
            }
            lblPwdReset.Text = message;
            lblPwdReset.Visible = true;
            Task.Delay(3000).ContinueWith(_ =>
            {
                try
                {
                    Invoke(new MethodInvoker(() => { lblPwdReset.Visible = false; }));
                }
                catch (Exception) { };
            });
        }
    }
}

