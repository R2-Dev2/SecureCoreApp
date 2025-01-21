﻿
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
            this.swPlanets = new CustomControls.SWCodi();
            this.swTxtPlanets = new CustomControls.SWTextBox();
            this.lblPlanets = new System.Windows.Forms.Label();
            this.swSpecies = new CustomControls.SWCodi();
            this.swTxtSpecies = new CustomControls.SWTextBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Location = new System.Drawing.Point(2318, 0);
            this.pbClose.Size = new System.Drawing.Size(28, 29);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(108, 246);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 33);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "Name";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(118, 190);
            this.lblCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(79, 33);
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
            this.swtxtName.Location = new System.Drawing.Point(266, 241);
            this.swtxtName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.swtxtName.Name = "swtxtName";
            this.swtxtName.required = true;
            this.swtxtName.Size = new System.Drawing.Size(700, 41);
            this.swtxtName.TabIndex = 2;
            // 
            // swtxtCode
            // 
            this.swtxtCode.codiSW = null;
            this.swtxtCode.columnName = "CodeUser";
            this.swtxtCode.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCode.isForeignKey = false;
            this.swtxtCode.Location = new System.Drawing.Point(268, 179);
            this.swtxtCode.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.swtxtCode.Name = "swtxtCode";
            this.swtxtCode.required = true;
            this.swtxtCode.Size = new System.Drawing.Size(277, 41);
            this.swtxtCode.TabIndex = 0;
            // 
            // swcodRank
            // 
            this.swcodRank.classeCS = "UserRanks";
            this.swcodRank.codeName = "CodeRank";
            this.swcodRank.controlId = "swtxtRank";
            this.swcodRank.descName = "DescRank";
            this.swcodRank.formCS = "frmUserRanksSearch";
            this.swcodRank.Location = new System.Drawing.Point(264, 302);
            this.swcodRank.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.swcodRank.Name = "swcodRank";
            this.swcodRank.nameId = "idUserRank";
            this.swcodRank.Size = new System.Drawing.Size(702, 45);
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
            this.swtxtRank.Location = new System.Drawing.Point(839, 308);
            this.swtxtRank.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.swtxtRank.Name = "swtxtRank";
            this.swtxtRank.required = true;
            this.swtxtRank.Size = new System.Drawing.Size(105, 25);
            this.swtxtRank.TabIndex = 40;
            this.swtxtRank.TabStop = false;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(114, 302);
            this.lblRank.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(83, 33);
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
            this.swUserCat.Location = new System.Drawing.Point(264, 358);
            this.swUserCat.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.swUserCat.Name = "swUserCat";
            this.swUserCat.nameId = "idUserCategory";
            this.swUserCat.Size = new System.Drawing.Size(702, 45);
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
            this.swTxtUserCategory.Location = new System.Drawing.Point(839, 369);
            this.swTxtUserCategory.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.swTxtUserCategory.Name = "swTxtUserCategory";
            this.swTxtUserCategory.required = true;
            this.swTxtUserCategory.Size = new System.Drawing.Size(105, 25);
            this.swTxtUserCategory.TabIndex = 43;
            this.swTxtUserCategory.TabStop = false;
            // 
            // lblUserCategory
            // 
            this.lblUserCategory.AutoSize = true;
            this.lblUserCategory.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCategory.Location = new System.Drawing.Point(67, 358);
            this.lblUserCategory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserCategory.Name = "lblUserCategory";
            this.lblUserCategory.Size = new System.Drawing.Size(130, 33);
            this.lblUserCategory.TabIndex = 42;
            this.lblUserCategory.Text = "Category";
            // 
            // btnPrintList
            // 
            this.btnPrintList.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintList.Location = new System.Drawing.Point(2200, 1006);
            this.btnPrintList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrintList.Name = "btnPrintList";
            this.btnPrintList.Size = new System.Drawing.Size(153, 59);
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
            this.crvAccessCards.DisplayToolbar = false;
            this.crvAccessCards.Location = new System.Drawing.Point(1144, 202);
            this.crvAccessCards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crvAccessCards.Name = "crvAccessCards";
            this.crvAccessCards.Size = new System.Drawing.Size(1210, 779);
            this.crvAccessCards.TabIndex = 45;
            this.crvAccessCards.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvAccessCards.ToolPanelWidth = 300;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(577, 190);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(147, 33);
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
            this.swtxtUsername.Location = new System.Drawing.Point(752, 179);
            this.swtxtUsername.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.swtxtUsername.Name = "swtxtUsername";
            this.swtxtUsername.required = true;
            this.swtxtUsername.Size = new System.Drawing.Size(216, 41);
            this.swtxtUsername.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(2032, 1006);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(159, 59);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // swPlanets
            // 
            this.swPlanets.classeCS = "Planets";
            this.swPlanets.codeName = "CodePlanet";
            this.swPlanets.controlId = "swTxtPlanets";
            this.swPlanets.descName = "DescPlanet";
            this.swPlanets.formCS = "frmPlanetsSearch";
            this.swPlanets.Location = new System.Drawing.Point(264, 414);
            this.swPlanets.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.swPlanets.Name = "swPlanets";
            this.swPlanets.nameId = "idPlanet";
            this.swPlanets.Size = new System.Drawing.Size(702, 45);
            this.swPlanets.TabIndex = 101;
            this.swPlanets.tableName = "Planets";
            // 
            // swTxtPlanets
            // 
            this.swTxtPlanets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTxtPlanets.codiSW = "swPlanets";
            this.swTxtPlanets.columnName = "idPlanet";
            this.swTxtPlanets.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swTxtPlanets.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtPlanets.isForeignKey = true;
            this.swTxtPlanets.Location = new System.Drawing.Point(808, 420);
            this.swTxtPlanets.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.swTxtPlanets.Name = "swTxtPlanets";
            this.swTxtPlanets.required = true;
            this.swTxtPlanets.Size = new System.Drawing.Size(158, 25);
            this.swTxtPlanets.TabIndex = 103;
            this.swTxtPlanets.TabStop = false;
            // 
            // lblPlanets
            // 
            this.lblPlanets.AutoSize = true;
            this.lblPlanets.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanets.Location = new System.Drawing.Point(86, 414);
            this.lblPlanets.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlanets.Name = "lblPlanets";
            this.lblPlanets.Size = new System.Drawing.Size(111, 33);
            this.lblPlanets.TabIndex = 102;
            this.lblPlanets.Text = "Planets";
            // 
            // swSpecies
            // 
            this.swSpecies.classeCS = "Planets";
            this.swSpecies.codeName = "CodeSpecie";
            this.swSpecies.controlId = "swTxtSpecies";
            this.swSpecies.descName = "DescSpecie";
            this.swSpecies.formCS = "frmSpeciesSearch";
            this.swSpecies.Location = new System.Drawing.Point(264, 470);
            this.swSpecies.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.swSpecies.Name = "swSpecies";
            this.swSpecies.nameId = "idSpecie";
            this.swSpecies.Size = new System.Drawing.Size(702, 45);
            this.swSpecies.TabIndex = 104;
            this.swSpecies.tableName = "Species";
            // 
            // swTxtSpecies
            // 
            this.swTxtSpecies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTxtSpecies.codiSW = "swSpecies";
            this.swTxtSpecies.columnName = "idSpecie";
            this.swTxtSpecies.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swTxtSpecies.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtSpecies.isForeignKey = true;
            this.swTxtSpecies.Location = new System.Drawing.Point(767, 476);
            this.swTxtSpecies.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.swTxtSpecies.Name = "swTxtSpecies";
            this.swTxtSpecies.required = true;
            this.swTxtSpecies.Size = new System.Drawing.Size(158, 25);
            this.swTxtSpecies.TabIndex = 106;
            this.swTxtSpecies.TabStop = false;
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(86, 470);
            this.lblSpecies.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(111, 33);
            this.lblSpecies.TabIndex = 105;
            this.lblSpecies.Text = "Species";
            // 
            // frmUserMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3270, 1723);
            this.Controls.Add(this.swSpecies);
            this.Controls.Add(this.swTxtSpecies);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.swPlanets);
            this.Controls.Add(this.swTxtPlanets);
            this.Controls.Add(this.lblPlanets);
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
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
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
            this.Controls.SetChildIndex(this.lblPlanets, 0);
            this.Controls.SetChildIndex(this.swTxtPlanets, 0);
            this.Controls.SetChildIndex(this.swPlanets, 0);
            this.Controls.SetChildIndex(this.lblSpecies, 0);
            this.Controls.SetChildIndex(this.swTxtSpecies, 0);
            this.Controls.SetChildIndex(this.swSpecies, 0);
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
        private CustomControls.SWCodi swPlanets;
        private CustomControls.SWTextBox swTxtPlanets;
        private System.Windows.Forms.Label lblPlanets;
        private CustomControls.SWCodi swSpecies;
        private CustomControls.SWTextBox swTxtSpecies;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Label lblPwdReset;
    }
}