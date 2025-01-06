
namespace SpaceShipsTypes
{
    partial class frmFiliationsSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.swtxtDescFiliation = new CustomControls.SWTextBox();
            this.swtxtCodeFiliation = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(91, 178);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(48, 20);
            this.lblCode.TabIndex = 25;
            this.lblCode.Text = "Code";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(39, 229);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(100, 20);
            this.lblDesc.TabIndex = 26;
            this.lblDesc.Text = "Description";
            // 
            // swtxtDescFiliation
            // 
            this.swtxtDescFiliation.codiSW = null;
            this.swtxtDescFiliation.columnName = "DescFiliation";
            this.swtxtDescFiliation.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDescFiliation.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDescFiliation.isForeignKey = false;
            this.swtxtDescFiliation.Location = new System.Drawing.Point(162, 225);
            this.swtxtDescFiliation.Name = "swtxtDescFiliation";
            this.swtxtDescFiliation.required = false;
            this.swtxtDescFiliation.Size = new System.Drawing.Size(245, 29);
            this.swtxtDescFiliation.TabIndex = 24;
            // 
            // swtxtCodeFiliation
            // 
            this.swtxtCodeFiliation.codiSW = null;
            this.swtxtCodeFiliation.columnName = "CodeFiliation";
            this.swtxtCodeFiliation.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCodeFiliation.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCodeFiliation.isForeignKey = false;
            this.swtxtCodeFiliation.Location = new System.Drawing.Point(162, 174);
            this.swtxtCodeFiliation.Name = "swtxtCodeFiliation";
            this.swtxtCodeFiliation.required = false;
            this.swtxtCodeFiliation.Size = new System.Drawing.Size(100, 29);
            this.swtxtCodeFiliation.TabIndex = 23;
            // 
            // frmFiliationsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 633);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.swtxtDescFiliation);
            this.Controls.Add(this.swtxtCodeFiliation);
            this.Name = "frmFiliationsSearch";
            this.Text = "frmFiliationsSearch";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCodeFiliation, 0);
            this.Controls.SetChildIndex(this.swtxtDescFiliation, 0);
            this.Controls.SetChildIndex(this.lblDesc, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDesc;
        private CustomControls.SWTextBox swtxtDescFiliation;
        private CustomControls.SWTextBox swtxtCodeFiliation;
    }
}