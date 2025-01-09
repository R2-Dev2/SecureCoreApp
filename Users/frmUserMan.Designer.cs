
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.swtxtName = new CustomControls.SWTextBox();
            this.swtxtCode = new CustomControls.SWTextBox();
            this.swcodRank = new CustomControls.SWCodi();
            this.swtxtRank = new CustomControls.SWTextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.swUserCat = new CustomControls.SWCodi();
            this.swTxtUserCategory = new CustomControls.SWTextBox();
            this.lblUserCategory = new System.Windows.Forms.Label();
            this.btnPrintList = new System.Windows.Forms.Button();
            this.crvAccessCards = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblUsername = new System.Windows.Forms.Label();
            this.swtxtUsername = new CustomControls.SWTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Location = new System.Drawing.Point(1916, 0);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(75, 175);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 20);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "Name";
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
            // swtxtName
            // 
            this.swtxtName.codiSW = null;
            this.swtxtName.columnName = "UserName";
            this.swtxtName.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtName.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtName.isForeignKey = false;
            this.swtxtName.Location = new System.Drawing.Point(146, 171);
            this.swtxtName.Name = "swtxtName";
            this.swtxtName.required = true;
            this.swtxtName.Size = new System.Drawing.Size(468, 29);
            this.swtxtName.TabIndex = 2;
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
            this.swtxtCode.TabIndex = 0;
            // 
            // swcodRank
            // 
            this.swcodRank.classeCS = "UserRanks";
            this.swcodRank.codeName = "CodeRank";
            this.swcodRank.controlId = "swtxtRank";
            this.swcodRank.descName = "DescRank";
            this.swcodRank.formCS = "frmUserRanksSearch";
            this.swcodRank.Location = new System.Drawing.Point(146, 218);
            this.swcodRank.Name = "swcodRank";
            this.swcodRank.nameId = "idUserRank";
            this.swcodRank.Size = new System.Drawing.Size(468, 29);
            this.swcodRank.TabIndex = 3;
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
            this.swtxtRank.TabStop = false;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(80, 223);
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
            this.swUserCat.Name = "swUserCat";
            this.swUserCat.nameId = "idUserCategory";
            this.swUserCat.Size = new System.Drawing.Size(468, 29);
            this.swUserCat.TabIndex = 4;
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
            this.swTxtUserCategory.TabStop = false;
            // 
            // lblUserCategory
            // 
            this.lblUserCategory.AutoSize = true;
            this.lblUserCategory.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCategory.Location = new System.Drawing.Point(50, 271);
            this.lblUserCategory.Name = "lblUserCategory";
            this.lblUserCategory.Size = new System.Drawing.Size(79, 20);
            this.lblUserCategory.TabIndex = 42;
            this.lblUserCategory.Text = "Category";
            // 
            // btnPrintList
            // 
            this.btnPrintList.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintList.Location = new System.Drawing.Point(1479, 644);
            this.btnPrintList.Name = "btnPrintList";
            this.btnPrintList.Size = new System.Drawing.Size(102, 38);
            this.btnPrintList.TabIndex = 5;
            this.btnPrintList.Text = "Print List";
            this.btnPrintList.UseVisualStyleBackColor = true;
            this.btnPrintList.Click += new System.EventHandler(this.btnViwerUser_Click);
            // 
            // crvAccessCards
            // 
            this.crvAccessCards.ActiveViewIndex = -1;
            this.crvAccessCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvAccessCards.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvAccessCards.Location = new System.Drawing.Point(774, 129);
            this.crvAccessCards.Name = "crvAccessCards";
            this.crvAccessCards.Size = new System.Drawing.Size(807, 499);
            this.crvAccessCards.TabIndex = 45;
            this.crvAccessCards.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(364, 129);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 20);
            this.lblUsername.TabIndex = 46;
            this.lblUsername.Text = "Username";
            // 
            // swtxtUsername
            // 
            this.swtxtUsername.codiSW = null;
            this.swtxtUsername.columnName = "Login";
            this.swtxtUsername.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtUsername.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtUsername.isForeignKey = false;
            this.swtxtUsername.Location = new System.Drawing.Point(469, 125);
            this.swtxtUsername.Name = "swtxtUsername";
            this.swtxtUsername.required = true;
            this.swtxtUsername.Size = new System.Drawing.Size(145, 29);
            this.swtxtUsername.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(1367, 644);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(106, 38);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmUserMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 706);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.swtxtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnPrintList);
            this.Controls.Add(this.swUserCat);
            this.Controls.Add(this.swTxtUserCategory);
            this.Controls.Add(this.lblUserCategory);
            this.Controls.Add(this.swcodRank);
            this.Controls.Add(this.swtxtRank);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.swtxtName);
            this.Controls.Add(this.swtxtCode);
            this.Controls.Add(this.crvAccessCards);
            this.Name = "frmUserMan";
            this.Text = "frmUserMan";
            this.Controls.SetChildIndex(this.crvAccessCards, 0);
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCode, 0);
            this.Controls.SetChildIndex(this.swtxtName, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblRank, 0);
            this.Controls.SetChildIndex(this.swtxtRank, 0);
            this.Controls.SetChildIndex(this.swcodRank, 0);
            this.Controls.SetChildIndex(this.lblUserCategory, 0);
            this.Controls.SetChildIndex(this.swTxtUserCategory, 0);
            this.Controls.SetChildIndex(this.swUserCat, 0);
            this.Controls.SetChildIndex(this.btnPrintList, 0);
            this.Controls.SetChildIndex(this.lblUsername, 0);
            this.Controls.SetChildIndex(this.swtxtUsername, 0);
            this.Controls.SetChildIndex(this.btnShow, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private CustomControls.SWTextBox swtxtName;
        private CustomControls.SWTextBox swtxtCode;
        private CustomControls.SWCodi swcodRank;
        private CustomControls.SWTextBox swtxtRank;
        private System.Windows.Forms.Label lblRank;
        private CustomControls.SWCodi swUserCat;
        private CustomControls.SWTextBox swTxtUserCategory;
        private System.Windows.Forms.Label lblUserCategory;
        private System.Windows.Forms.Button btnPrintList;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvAccessCards;
        private System.Windows.Forms.Label lblUsername;
        private CustomControls.SWTextBox swtxtUsername;
        private System.Windows.Forms.Button btnShow;
    }
}