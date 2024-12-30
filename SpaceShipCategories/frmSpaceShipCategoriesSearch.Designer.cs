
namespace SpaceShipCategories
{
    partial class frmSpaceShipCategoriesSearch
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
            this.swtxtDescSpaceShipCategory = new CustomControls.SWTextBox();
            this.swtxtCodeSpaceShipCategory = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(91, 133);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(48, 20);
            this.lblCode.TabIndex = 25;
            this.lblCode.Text = "Code";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(39, 184);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(100, 20);
            this.lblDesc.TabIndex = 26;
            this.lblDesc.Text = "Description";
            // 
            // swtxtDescSpaceShipCategory
            // 
            this.swtxtDescSpaceShipCategory.codiSW = null;
            this.swtxtDescSpaceShipCategory.columnName = "DescSpaceShipCategory";
            this.swtxtDescSpaceShipCategory.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDescSpaceShipCategory.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDescSpaceShipCategory.isForeignKey = false;
            this.swtxtDescSpaceShipCategory.Location = new System.Drawing.Point(162, 180);
            this.swtxtDescSpaceShipCategory.Name = "swtxtDescSpaceShipCategory";
            this.swtxtDescSpaceShipCategory.required = false;
            this.swtxtDescSpaceShipCategory.Size = new System.Drawing.Size(245, 29);
            this.swtxtDescSpaceShipCategory.TabIndex = 24;
            // 
            // swtxtCodeSpaceShipCategory
            // 
            this.swtxtCodeSpaceShipCategory.codiSW = null;
            this.swtxtCodeSpaceShipCategory.columnName = "CodeSpaceShipCategory";
            this.swtxtCodeSpaceShipCategory.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCodeSpaceShipCategory.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCodeSpaceShipCategory.isForeignKey = false;
            this.swtxtCodeSpaceShipCategory.Location = new System.Drawing.Point(162, 129);
            this.swtxtCodeSpaceShipCategory.Name = "swtxtCodeSpaceShipCategory";
            this.swtxtCodeSpaceShipCategory.required = false;
            this.swtxtCodeSpaceShipCategory.Size = new System.Drawing.Size(100, 29);
            this.swtxtCodeSpaceShipCategory.TabIndex = 23;
            // 
            // frmSpaceShipCategoriesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 633);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.swtxtDescSpaceShipCategory);
            this.Controls.Add(this.swtxtCodeSpaceShipCategory);
            this.Name = "frmSpaceShipCategoriesSearch";
            this.Text = "frmSpaceShipCategoriesSearch";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCodeSpaceShipCategory, 0);
            this.Controls.SetChildIndex(this.swtxtDescSpaceShipCategory, 0);
            this.Controls.SetChildIndex(this.lblDesc, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDesc;
        private CustomControls.SWTextBox swtxtDescSpaceShipCategory;
        private CustomControls.SWTextBox swtxtCodeSpaceShipCategory;
    }
}