﻿
namespace Planets
{
    partial class frmSpeciesSearch
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
            this.lblDescSpecie = new System.Windows.Forms.Label();
            this.lblCodeSpec = new System.Windows.Forms.Label();
            this.swtxtDesc = new CustomControls.SWTextBox();
            this.swtxtCode = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescSpecie
            // 
            this.lblDescSpecie.AutoSize = true;
            this.lblDescSpecie.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSpecie.Location = new System.Drawing.Point(39, 232);
            this.lblDescSpecie.Name = "lblDescSpecie";
            this.lblDescSpecie.Size = new System.Drawing.Size(100, 20);
            this.lblDescSpecie.TabIndex = 20;
            this.lblDescSpecie.Text = "Description";
            // 
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(91, 179);
            this.lblCodeSpec.Name = "lblCodeSpec";
            this.lblCodeSpec.Size = new System.Drawing.Size(48, 20);
            this.lblCodeSpec.TabIndex = 19;
            this.lblCodeSpec.Text = "Code";
            // 
            // swtxtDesc
            // 
            this.swtxtDesc.codiSW = null;
            this.swtxtDesc.columnName = "DescSpecie";
            this.swtxtDesc.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDesc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDesc.isForeignKey = false;
            this.swtxtDesc.Location = new System.Drawing.Point(154, 228);
            this.swtxtDesc.Name = "swtxtDesc";
            this.swtxtDesc.required = false;
            this.swtxtDesc.Size = new System.Drawing.Size(244, 29);
            this.swtxtDesc.TabIndex = 6;
            // 
            // swtxtCode
            // 
            this.swtxtCode.codiSW = null;
            this.swtxtCode.columnName = "CodeSpecie";
            this.swtxtCode.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCode.isForeignKey = false;
            this.swtxtCode.Location = new System.Drawing.Point(154, 175);
            this.swtxtCode.Name = "swtxtCode";
            this.swtxtCode.required = false;
            this.swtxtCode.Size = new System.Drawing.Size(100, 29);
            this.swtxtCode.TabIndex = 5;
            // 
            // frmSpeciesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 633);
            this.Controls.Add(this.lblCodeSpec);
            this.Controls.Add(this.lblDescSpecie);
            this.Controls.Add(this.swtxtDesc);
            this.Controls.Add(this.swtxtCode);
            this.Name = "frmSpeciesSearch";
            this.Text = "frmSpeciesSearch";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCode, 0);
            this.Controls.SetChildIndex(this.swtxtDesc, 0);
            this.Controls.SetChildIndex(this.lblDescSpecie, 0);
            this.Controls.SetChildIndex(this.lblCodeSpec, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescSpecie;
        private System.Windows.Forms.Label lblCodeSpec;
        private CustomControls.SWTextBox swtxtDesc;
        private CustomControls.SWTextBox swtxtCode;
    }
}