
namespace OrderReport
{
    partial class frmOrderReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderReport));
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.crvOrder = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalLlistatComandes1 = new OrderReport.CrystalLlistatComandes();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.lblOrderReport = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1605, 2);
            this.pbClose.Margin = new System.Windows.Forms.Padding(0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(38, 36);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 21;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // crvOrder
            // 
            this.crvOrder.ActiveViewIndex = -1;
            this.crvOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvOrder.DisplayToolbar = false;
            this.crvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvOrder.Location = new System.Drawing.Point(0, 0);
            this.crvOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crvOrder.Name = "crvOrder";
            this.crvOrder.Size = new System.Drawing.Size(2282, 1537);
            this.crvOrder.TabIndex = 27;
            this.crvOrder.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvOrder.ToolPanelWidth = 300;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crvOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2282, 1537);
            this.panel1.TabIndex = 28;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnShowReport.Location = new System.Drawing.Point(34, 250);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(198, 56);
            this.btnShowReport.TabIndex = 22;
            this.btnShowReport.Text = "Show Order";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 25;
            this.label1.Text = "Order Number";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(240, 176);
            this.txtOrderNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(235, 39);
            this.txtOrderNumber.TabIndex = 26;
            // 
            // lblOrderReport
            // 
            this.lblOrderReport.AutoSize = true;
            this.lblOrderReport.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblOrderReport.Location = new System.Drawing.Point(23, 50);
            this.lblOrderReport.Name = "lblOrderReport";
            this.lblOrderReport.Size = new System.Drawing.Size(350, 62);
            this.lblOrderReport.TabIndex = 116;
            this.lblOrderReport.Text = "Order Report";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(28, 344);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(200, 33);
            this.lblError.TabIndex = 117;
            this.lblError.Text = "No order found";
            this.lblError.Visible = false;
            // 
            // frmOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(2282, 1923);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblOrderReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.pbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOrderReport";
            this.Text = "frmEDI";
            this.Load += new System.EventHandler(this.frmEDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox pbClose;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvOrder;
        private CrystalLlistatComandes CrystalLlistatComandes1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label lblOrderReport;
        private System.Windows.Forms.Label lblError;
    }
}