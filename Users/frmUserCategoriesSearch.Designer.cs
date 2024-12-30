
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
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(97, 146);
            this.lblCodeSpec.Name = "lblCodeSpec";
            this.lblCodeSpec.Size = new System.Drawing.Size(48, 20);
            this.lblCodeSpec.TabIndex = 25;
            this.lblCodeSpec.Text = "Code";
            // 
            // lblDescSpecie
            // 
            this.lblDescSpecie.AutoSize = true;
            this.lblDescSpecie.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSpecie.Location = new System.Drawing.Point(45, 190);
            this.lblDescSpecie.Name = "lblDescSpecie";
            this.lblDescSpecie.Size = new System.Drawing.Size(100, 20);
            this.lblDescSpecie.TabIndex = 26;
            this.lblDescSpecie.Text = "Description";
            // 
            // swtxtDesc
            // 
            this.swtxtDesc.columnName = "DescCategory";
            this.swtxtDesc.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDesc.isForeignKey = false;
            this.swtxtDesc.Location = new System.Drawing.Point(174, 186);
            this.swtxtDesc.Name = "swtxtDesc";
            this.swtxtDesc.required = false;
            this.swtxtDesc.Size = new System.Drawing.Size(236, 29);
            this.swtxtDesc.TabIndex = 24;
            // 
            // swtxtCodePlan
            // 
            this.swtxtCodePlan.columnName = "CodeCategory";
            this.swtxtCodePlan.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCodePlan.isForeignKey = false;
            this.swtxtCodePlan.Location = new System.Drawing.Point(174, 142);
            this.swtxtCodePlan.Name = "swtxtCodePlan";
            this.swtxtCodePlan.required = false;
            this.swtxtCodePlan.Size = new System.Drawing.Size(125, 29);
            this.swtxtCodePlan.TabIndex = 23;
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.AutoSize = true;
            this.lblAccessLevel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessLevel.Location = new System.Drawing.Point(39, 234);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(106, 20);
            this.lblAccessLevel.TabIndex = 28;
            this.lblAccessLevel.Text = "Access Level";
            // 
            // swTxtAccessLevel
            // 
            this.swTxtAccessLevel.columnName = "Access Level";
            this.swTxtAccessLevel.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtAccessLevel.isForeignKey = false;
            this.swTxtAccessLevel.Location = new System.Drawing.Point(174, 230);
            this.swTxtAccessLevel.Name = "swTxtAccessLevel";
            this.swTxtAccessLevel.required = false;
            this.swTxtAccessLevel.Size = new System.Drawing.Size(236, 29);
            this.swTxtAccessLevel.TabIndex = 27;
            // 
            // frmUserCategoriesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 633);
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
        private CustomControls.SWTextBox swtxtCodePlan;
        private System.Windows.Forms.Label lblAccessLevel;
        private CustomControls.SWTextBox swTxtAccessLevel;
    }
}