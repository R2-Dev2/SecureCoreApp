
namespace UserCategories
{
    partial class frmUserCategoriesMan
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
            this.lblCodeCategory = new System.Windows.Forms.Label();
            this.lblDescUserCategory = new System.Windows.Forms.Label();
            this.swDescCategory = new CustomControls.SWTextBox();
            this.swCodeCategory = new CustomControls.SWTextBox();
            this.lblAccesLevel = new System.Windows.Forms.Label();
            this.swAccessLevel = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeCategory
            // 
            this.lblCodeCategory.AutoSize = true;
            this.lblCodeCategory.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeCategory.Location = new System.Drawing.Point(109, 166);
            this.lblCodeCategory.Name = "lblCodeCategory";
            this.lblCodeCategory.Size = new System.Drawing.Size(48, 20);
            this.lblCodeCategory.TabIndex = 36;
            this.lblCodeCategory.Text = "Code";
            // 
            // lblDescUserCategory
            // 
            this.lblDescUserCategory.AutoSize = true;
            this.lblDescUserCategory.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescUserCategory.Location = new System.Drawing.Point(57, 220);
            this.lblDescUserCategory.Name = "lblDescUserCategory";
            this.lblDescUserCategory.Size = new System.Drawing.Size(100, 20);
            this.lblDescUserCategory.TabIndex = 35;
            this.lblDescUserCategory.Text = "Description";
            // 
            // swDescCategory
            // 
            this.swDescCategory.codiSW = null;
            this.swDescCategory.columnName = "DescCategory";
            this.swDescCategory.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swDescCategory.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swDescCategory.isForeignKey = false;
            this.swDescCategory.Location = new System.Drawing.Point(172, 216);
            this.swDescCategory.Name = "swDescCategory";
            this.swDescCategory.required = false;
            this.swDescCategory.Size = new System.Drawing.Size(187, 29);
            this.swDescCategory.TabIndex = 34;
            this.swDescCategory.Tag = "DescCategory";
            // 
            // swCodeCategory
            // 
            this.swCodeCategory.codiSW = null;
            this.swCodeCategory.columnName = "CodeCategory";
            this.swCodeCategory.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swCodeCategory.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swCodeCategory.isForeignKey = false;
            this.swCodeCategory.Location = new System.Drawing.Point(172, 157);
            this.swCodeCategory.Name = "swCodeCategory";
            this.swCodeCategory.required = true;
            this.swCodeCategory.Size = new System.Drawing.Size(101, 29);
            this.swCodeCategory.TabIndex = 33;
            this.swCodeCategory.Tag = "CodeCategory";
            // 
            // lblAccesLevel
            // 
            this.lblAccesLevel.AutoSize = true;
            this.lblAccesLevel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccesLevel.Location = new System.Drawing.Point(51, 278);
            this.lblAccesLevel.Name = "lblAccesLevel";
            this.lblAccesLevel.Size = new System.Drawing.Size(106, 20);
            this.lblAccesLevel.TabIndex = 38;
            this.lblAccesLevel.Text = "Access Level";
            // 
            // swAccessLevel
            // 
            this.swAccessLevel.codiSW = null;
            this.swAccessLevel.columnName = "AccessLevel";
            this.swAccessLevel.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swAccessLevel.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swAccessLevel.isForeignKey = false;
            this.swAccessLevel.Location = new System.Drawing.Point(172, 274);
            this.swAccessLevel.Name = "swAccessLevel";
            this.swAccessLevel.required = true;
            this.swAccessLevel.Size = new System.Drawing.Size(187, 29);
            this.swAccessLevel.TabIndex = 37;
            this.swAccessLevel.Tag = "AccessLevel";
            // 
            // frmUserCategoriesMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 706);
            this.Controls.Add(this.lblAccesLevel);
            this.Controls.Add(this.swAccessLevel);
            this.Controls.Add(this.lblCodeCategory);
            this.Controls.Add(this.lblDescUserCategory);
            this.Controls.Add(this.swDescCategory);
            this.Controls.Add(this.swCodeCategory);
            this.Name = "frmUserCategoriesMan";
            this.Text = "frmuserCategories";
            this.Load += new System.EventHandler(this.frmuserCategories_Load);
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swCodeCategory, 0);
            this.Controls.SetChildIndex(this.swDescCategory, 0);
            this.Controls.SetChildIndex(this.lblDescUserCategory, 0);
            this.Controls.SetChildIndex(this.lblCodeCategory, 0);
            this.Controls.SetChildIndex(this.swAccessLevel, 0);
            this.Controls.SetChildIndex(this.lblAccesLevel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeCategory;
        private System.Windows.Forms.Label lblDescUserCategory;
        private CustomControls.SWTextBox swDescCategory;
        private CustomControls.SWTextBox swCodeCategory;
        private System.Windows.Forms.Label lblAccesLevel;
        private CustomControls.SWTextBox swAccessLevel;
    }
}