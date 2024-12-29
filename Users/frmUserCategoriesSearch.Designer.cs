﻿
namespace UserCategories
{
    partial class frmUserCategoriesSearch
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
            this.swtxtCodePlan = new CustomControls.SWTextBox();
            this.lblAccessLevel = new System.Windows.Forms.Label();
            this.swTxtAccessLevel = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Location = new System.Drawing.Point(1087, 0);
            // 
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(220, 215);
            this.lblCodeSpec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeSpec.Name = "lblCodeSpec";
            this.lblCodeSpec.Size = new System.Drawing.Size(79, 33);
            this.lblCodeSpec.TabIndex = 25;
            this.lblCodeSpec.Text = "Code";
            // 
            // lblDescSpecie
            // 
            this.lblDescSpecie.AutoSize = true;
            this.lblDescSpecie.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSpecie.Location = new System.Drawing.Point(142, 295);
            this.lblDescSpecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescSpecie.Name = "lblDescSpecie";
            this.lblDescSpecie.Size = new System.Drawing.Size(167, 33);
            this.lblDescSpecie.TabIndex = 26;
            this.lblDescSpecie.Text = "Description";
            // 
            // swtxtDesc
            // 
            this.swtxtDesc.codiSW = null;
            this.swtxtDesc.columnName = "DescCategory";
            this.swtxtDesc.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDesc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDesc.isForeignKey = false;
            this.swtxtDesc.Location = new System.Drawing.Point(305, 281);
            this.swtxtDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtDesc.Name = "swtxtDesc";
            this.swtxtDesc.required = false;
            this.swtxtDesc.Size = new System.Drawing.Size(148, 41);
            this.swtxtDesc.TabIndex = 24;
            // 
            // swtxtCodePlan
            // 
            this.swtxtCodePlan.codiSW = null;
            this.swtxtCodePlan.columnName = "CodeCategory";
            this.swtxtCodePlan.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCodePlan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCodePlan.isForeignKey = false;
            this.swtxtCodePlan.Location = new System.Drawing.Point(305, 206);
            this.swtxtCodePlan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtCodePlan.Name = "swtxtCodePlan";
            this.swtxtCodePlan.required = false;
            this.swtxtCodePlan.Size = new System.Drawing.Size(148, 41);
            this.swtxtCodePlan.TabIndex = 23;
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.AutoSize = true;
            this.lblAccessLevel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessLevel.Location = new System.Drawing.Point(471, 211);
            this.lblAccessLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(174, 33);
            this.lblAccessLevel.TabIndex = 28;
            this.lblAccessLevel.Text = "Access Level";
            // 
            // swTxtAccessLevel
            // 
            this.swTxtAccessLevel.codiSW = null;
            this.swTxtAccessLevel.columnName = "Access Level";
            this.swTxtAccessLevel.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtAccessLevel.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtAccessLevel.isForeignKey = false;
            this.swTxtAccessLevel.Location = new System.Drawing.Point(653, 211);
            this.swTxtAccessLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTxtAccessLevel.Name = "swTxtAccessLevel";
            this.swTxtAccessLevel.required = false;
            this.swTxtAccessLevel.Size = new System.Drawing.Size(216, 41);
            this.swTxtAccessLevel.TabIndex = 27;
            // 
            // frmUserCategoriesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 869);
            this.Controls.Add(this.lblAccessLevel);
            this.Controls.Add(this.swTxtAccessLevel);
            this.Controls.Add(this.lblCodeSpec);
            this.Controls.Add(this.lblDescSpecie);
            this.Controls.Add(this.swtxtDesc);
            this.Controls.Add(this.swtxtCodePlan);
            this.Name = "frmUserCategoriesSearch";
            this.Text = "frmUserCategoriesSearch";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCodePlan, 0);
            this.Controls.SetChildIndex(this.swtxtDesc, 0);
            this.Controls.SetChildIndex(this.lblDescSpecie, 0);
            this.Controls.SetChildIndex(this.lblCodeSpec, 0);
            this.Controls.SetChildIndex(this.swTxtAccessLevel, 0);
            this.Controls.SetChildIndex(this.lblAccessLevel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeSpec;
        private System.Windows.Forms.Label lblDescSpecie;
        private CustomControls.SWTextBox swtxtDesc;
        public CustomControls.SWTextBox swtxtCodePlan;
        private System.Windows.Forms.Label lblAccessLevel;
        public CustomControls.SWTextBox swTxtAccessLevel;
    }
}