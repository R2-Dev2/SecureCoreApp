using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using DataAccess;

namespace OrderReport
{
    public partial class frmOrderReport : Form
    {
        private string connectionString;
        private AccesADades accesADades;
        private ReportDocument cryRpt;
        public frmOrderReport()
        {
            InitializeComponent();
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

        private void frmEDI_Load(object sender, EventArgs e)
        {
            this.connectionString = "SecureCore";
            this.accesADades = new AccesADades(this.connectionString);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            cryRpt = new ReportDocument();
            cryRpt.Load("CrystalLlistatComandes.rpt");
            SetCredentialsInfo();
            string codeOrder = txtOrderNumber.Text;

            cryRpt.RecordSelectionFormula = $"{{Orders.codeOrder}} = \"{codeOrder}\"";

            if (cryRpt.HasRecords)
            {
                crvOrder.ReportSource = cryRpt;
                lblError.Visible = false;
            }
            else
            {
                crvOrder.ReportSource = null;
                lblError.Visible = true;
            }
        }
    }
}
