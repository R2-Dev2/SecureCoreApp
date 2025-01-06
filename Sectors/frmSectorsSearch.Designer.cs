
namespace Sectors
{
    partial class frmSectorsSearch
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
            this.lblCodeSpec = new System.Windows.Forms.Label();
            this.lblDescSpecie = new System.Windows.Forms.Label();
            this.swtxtDesc = new CustomControls.SWTextBox();
            this.swtxtCode = new CustomControls.SWTextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.swtxtRemarks = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(91, 131);
            this.lblCodeSpec.Name = "lblCodeSpec";
            this.lblCodeSpec.Size = new System.Drawing.Size(48, 20);
            this.lblCodeSpec.TabIndex = 25;
            this.lblCodeSpec.Text = "Code";
            // 
            // lblDescSpecie
            // 
            this.lblDescSpecie.AutoSize = true;
            this.lblDescSpecie.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSpecie.Location = new System.Drawing.Point(39, 181);
            this.lblDescSpecie.Name = "lblDescSpecie";
            this.lblDescSpecie.Size = new System.Drawing.Size(100, 20);
            this.lblDescSpecie.TabIndex = 26;
            this.lblDescSpecie.Text = "Description";
            // 
            // swtxtDesc
            // 
            this.swtxtDesc.codiSW = null;
            this.swtxtDesc.columnName = "DescSector";
            this.swtxtDesc.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDesc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDesc.isForeignKey = false;
            this.swtxtDesc.Location = new System.Drawing.Point(157, 177);
            this.swtxtDesc.Name = "swtxtDesc";
            this.swtxtDesc.required = false;
            this.swtxtDesc.Size = new System.Drawing.Size(245, 29);
            this.swtxtDesc.TabIndex = 24;
            // 
            // swtxtCode
            // 
            this.swtxtCode.codiSW = null;
            this.swtxtCode.columnName = "CodeSector";
            this.swtxtCode.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCode.isForeignKey = false;
            this.swtxtCode.Location = new System.Drawing.Point(157, 127);
            this.swtxtCode.Name = "swtxtCode";
            this.swtxtCode.required = false;
            this.swtxtCode.Size = new System.Drawing.Size(101, 29);
            this.swtxtCode.TabIndex = 23;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(60, 232);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(79, 20);
            this.lblRemarks.TabIndex = 28;
            this.lblRemarks.Text = "Remarks";
            // 
            // swtxtRemarks
            // 
            this.swtxtRemarks.codiSW = null;
            this.swtxtRemarks.columnName = "Remarks";
            this.swtxtRemarks.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtRemarks.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtRemarks.isForeignKey = false;
            this.swtxtRemarks.Location = new System.Drawing.Point(157, 227);
            this.swtxtRemarks.Name = "swtxtRemarks";
            this.swtxtRemarks.required = false;
            this.swtxtRemarks.Size = new System.Drawing.Size(314, 29);
            this.swtxtRemarks.TabIndex = 27;
            // 
            // frmSectorSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 633);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.swtxtRemarks);
            this.Controls.Add(this.lblCodeSpec);
            this.Controls.Add(this.lblDescSpecie);
            this.Controls.Add(this.swtxtDesc);
            this.Controls.Add(this.swtxtCode);
            this.Name = "frmSectorSearch";
            this.Text = "frmSectorSearch";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCode, 0);
            this.Controls.SetChildIndex(this.swtxtDesc, 0);
            this.Controls.SetChildIndex(this.lblDescSpecie, 0);
            this.Controls.SetChildIndex(this.lblCodeSpec, 0);
            this.Controls.SetChildIndex(this.swtxtRemarks, 0);
            this.Controls.SetChildIndex(this.lblRemarks, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeSpec;
        private System.Windows.Forms.Label lblDescSpecie;
        private CustomControls.SWTextBox swtxtDesc;
        private CustomControls.SWTextBox swtxtCode;
        private System.Windows.Forms.Label lblRemarks;
        private CustomControls.SWTextBox swtxtRemarks;
    }
}