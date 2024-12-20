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
            this.swtxtDescPlan = new CustomControls.SWTextBox();
            this.swtxtCodePlan = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescSpecie
            // 
            this.lblDescSpecie.AutoSize = true;
            this.lblDescSpecie.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSpecie.Location = new System.Drawing.Point(141, 292);
            this.lblDescSpecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescSpecie.Name = "lblDescSpecie";
            this.lblDescSpecie.Size = new System.Drawing.Size(167, 33);
            this.lblDescSpecie.TabIndex = 20;
            this.lblDescSpecie.Text = "Description";
            // 
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(219, 212);
            this.lblCodeSpec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeSpec.Name = "lblCodeSpec";
            this.lblCodeSpec.Size = new System.Drawing.Size(79, 33);
            this.lblCodeSpec.TabIndex = 19;
            this.lblCodeSpec.Text = "Code";
            // 
            // swtxtDescPlan
            // 
            this.swtxtDescPlan.codiSW = null;
            this.swtxtDescPlan.columnName = "DescSpecie";
            this.swtxtDescPlan.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDescPlan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDescPlan.isForeignKey = false;
            this.swtxtDescPlan.Location = new System.Drawing.Point(304, 278);
            this.swtxtDescPlan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtDescPlan.Name = "swtxtDescPlan";
            this.swtxtDescPlan.required = false;
            this.swtxtDescPlan.Size = new System.Drawing.Size(148, 41);
            this.swtxtDescPlan.TabIndex = 6;
            // 
            // swtxtCodePlan
            // 
            this.swtxtCodePlan.codiSW = null;
            this.swtxtCodePlan.columnName = "CodeSpecie";
            this.swtxtCodePlan.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCodePlan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCodePlan.isForeignKey = false;
            this.swtxtCodePlan.Location = new System.Drawing.Point(304, 203);
            this.swtxtCodePlan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtCodePlan.Name = "swtxtCodePlan";
            this.swtxtCodePlan.required = false;
            this.swtxtCodePlan.Size = new System.Drawing.Size(148, 41);
            this.swtxtCodePlan.TabIndex = 5;
            // 
            // frmSpeciesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 895);
            this.Controls.Add(this.lblCodeSpec);
            this.Controls.Add(this.lblDescSpecie);
            this.Controls.Add(this.swtxtDescPlan);
            this.Controls.Add(this.swtxtCodePlan);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmSpeciesSearch";
            this.Text = "frmSpeciesSearch";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCodePlan, 0);
            this.Controls.SetChildIndex(this.swtxtDescPlan, 0);
            this.Controls.SetChildIndex(this.lblDescSpecie, 0);
            this.Controls.SetChildIndex(this.lblCodeSpec, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescSpecie;
        private System.Windows.Forms.Label lblCodeSpec;
        private CustomControls.SWTextBox swtxtDescPlan;
        public CustomControls.SWTextBox swtxtCodePlan;
    }
}