
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
            this.btnShowReport = new System.Windows.Forms.Button();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crvOrder = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalLlistatComandes1 = new OrderReport.CrystalLlistatComandes();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1059, 0);
            this.pbClose.Margin = new System.Windows.Forms.Padding(0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 23);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 21;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(23, 98);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(105, 48);
            this.btnShowReport.TabIndex = 22;
            this.btnShowReport.Text = "Show Order";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(144, 53);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(100, 22);
            this.txtOrderNumber.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Order Number:";
            // 
            // crvOrder
            // 
            this.crvOrder.ActiveViewIndex = -1;
            this.crvOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvOrder.DisplayToolbar = false;
            this.crvOrder.Location = new System.Drawing.Point(23, 152);
            this.crvOrder.Name = "crvOrder";
            this.crvOrder.Size = new System.Drawing.Size(1033, 542);
            this.crvOrder.TabIndex = 27;
            this.crvOrder.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1084, 706);
            this.Controls.Add(this.crvOrder);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.pbClose);
            this.Name = "frmOrderReport";
            this.Text = "frmEDI";
            this.Load += new System.EventHandler(this.frmEDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvOrder;
        private CrystalLlistatComandes CrystalLlistatComandes1;
    }
}