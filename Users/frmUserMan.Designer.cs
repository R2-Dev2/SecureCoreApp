
namespace Users
{
    partial class frmUserMan
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.swtxtUserName = new CustomControls.SWTextBox();
            this.swtxtCode = new CustomControls.SWTextBox();
            this.swcodRank = new CustomControls.SWCodi();
            this.swtxtRank = new CustomControls.SWTextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.swUserCat = new CustomControls.SWCodi();
            this.swTxtUserCategory = new CustomControls.SWTextBox();
            this.lblUserCategory = new System.Windows.Forms.Label();
            this.btnViwerUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(75, 175);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(54, 20);
            this.lblUserName.TabIndex = 37;
            this.lblUserName.Text = "Name";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(81, 129);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(48, 20);
            this.lblCode.TabIndex = 36;
            this.lblCode.Text = "Code";
            // 
            // swtxtUserName
            // 
            this.swtxtUserName.codiSW = null;
            this.swtxtUserName.columnName = "UserName";
            this.swtxtUserName.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtUserName.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtUserName.isForeignKey = false;
            this.swtxtUserName.Location = new System.Drawing.Point(146, 171);
            this.swtxtUserName.Name = "swtxtUserName";
            this.swtxtUserName.required = false;
            this.swtxtUserName.Size = new System.Drawing.Size(296, 29);
            this.swtxtUserName.TabIndex = 33;
            // 
            // swtxtCode
            // 
            this.swtxtCode.codiSW = null;
            this.swtxtCode.columnName = "CodeUser";
            this.swtxtCode.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCode.isForeignKey = false;
            this.swtxtCode.Location = new System.Drawing.Point(146, 125);
            this.swtxtCode.Name = "swtxtCode";
            this.swtxtCode.required = true;
            this.swtxtCode.Size = new System.Drawing.Size(186, 29);
            this.swtxtCode.TabIndex = 32;
            // 
            // swcodRank
            // 
            this.swcodRank.classeCS = "UserRanks";
            this.swcodRank.codeName = "CodeRank";
            this.swcodRank.controlId = "swtxtRank";
            this.swcodRank.descName = "DescRank";
            this.swcodRank.formCS = "frmUserRankSearch";
            this.swcodRank.Location = new System.Drawing.Point(146, 218);
            this.swcodRank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swcodRank.Name = "swcodRank";
            this.swcodRank.nameId = "idUserRank";
            this.swcodRank.Size = new System.Drawing.Size(402, 29);
            this.swcodRank.TabIndex = 38;
            this.swcodRank.tableName = "UserRanks";
            // 
            // swtxtRank
            // 
            this.swtxtRank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swtxtRank.codiSW = "swcodRank";
            this.swtxtRank.columnName = "idUserRank";
            this.swtxtRank.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtRank.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtRank.isForeignKey = true;
            this.swtxtRank.Location = new System.Drawing.Point(469, 227);
            this.swtxtRank.Name = "swtxtRank";
            this.swtxtRank.required = true;
            this.swtxtRank.Size = new System.Drawing.Size(70, 16);
            this.swtxtRank.TabIndex = 40;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(80, 227);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(49, 20);
            this.lblRank.TabIndex = 39;
            this.lblRank.Text = "Rank";
            // 
            // swUserCat
            // 
            this.swUserCat.classeCS = "UserCategories";
            this.swUserCat.codeName = "CodeCategory";
            this.swUserCat.controlId = "swTxtUserCategory";
            this.swUserCat.descName = "DescCategory";
            this.swUserCat.formCS = "frmUserCategoriesSearch";
            this.swUserCat.Location = new System.Drawing.Point(146, 266);
            this.swUserCat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swUserCat.Name = "swUserCat";
            this.swUserCat.nameId = "idUserCategory";
            this.swUserCat.Size = new System.Drawing.Size(402, 29);
            this.swUserCat.TabIndex = 41;
            this.swUserCat.tableName = "UserCategories";
            // 
            // swTxtUserCategory
            // 
            this.swTxtUserCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTxtUserCategory.codiSW = "swUserCat";
            this.swTxtUserCategory.columnName = "idUserCategory";
            this.swTxtUserCategory.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swTxtUserCategory.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtUserCategory.isForeignKey = true;
            this.swTxtUserCategory.Location = new System.Drawing.Point(421, 275);
            this.swTxtUserCategory.Name = "swTxtUserCategory";
            this.swTxtUserCategory.required = true;
            this.swTxtUserCategory.Size = new System.Drawing.Size(70, 16);
            this.swTxtUserCategory.TabIndex = 43;
            // 
            // lblUserCategory
            // 
            this.lblUserCategory.AutoSize = true;
            this.lblUserCategory.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCategory.Location = new System.Drawing.Point(50, 275);
            this.lblUserCategory.Name = "lblUserCategory";
            this.lblUserCategory.Size = new System.Drawing.Size(79, 20);
            this.lblUserCategory.TabIndex = 42;
            this.lblUserCategory.Text = "Category";
            // 
            // btnViwerUser
            // 
            this.btnViwerUser.Location = new System.Drawing.Point(431, 644);
            this.btnViwerUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnViwerUser.Name = "btnViwerUser";
            this.btnViwerUser.Size = new System.Drawing.Size(86, 38);
            this.btnViwerUser.TabIndex = 44;
            this.btnViwerUser.Text = "View";
            this.btnViwerUser.UseVisualStyleBackColor = true;
            // 
            // frmUserMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 706);
            this.Controls.Add(this.btnViwerUser);
            this.Controls.Add(this.swUserCat);
            this.Controls.Add(this.swTxtUserCategory);
            this.Controls.Add(this.lblUserCategory);
            this.Controls.Add(this.swcodRank);
            this.Controls.Add(this.swtxtRank);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.swtxtUserName);
            this.Controls.Add(this.swtxtCode);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUserMan";
            this.Text = "frmUserMan";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCode, 0);
            this.Controls.SetChildIndex(this.swtxtUserName, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.lblUserName, 0);
            this.Controls.SetChildIndex(this.lblRank, 0);
            this.Controls.SetChildIndex(this.swtxtRank, 0);
            this.Controls.SetChildIndex(this.swcodRank, 0);
            this.Controls.SetChildIndex(this.lblUserCategory, 0);
            this.Controls.SetChildIndex(this.swTxtUserCategory, 0);
            this.Controls.SetChildIndex(this.swUserCat, 0);
            this.Controls.SetChildIndex(this.btnViwerUser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblCode;
        private CustomControls.SWTextBox swtxtUserName;
        private CustomControls.SWTextBox swtxtCode;
        private CustomControls.SWCodi swcodRank;
        private CustomControls.SWTextBox swtxtRank;
        private System.Windows.Forms.Label lblRank;
        private CustomControls.SWCodi swUserCat;
        private CustomControls.SWTextBox swTxtUserCategory;
        private System.Windows.Forms.Label lblUserCategory;
        private System.Windows.Forms.Button btnViwerUser;
    }
}