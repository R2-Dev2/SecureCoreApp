﻿
namespace SpaceShipsTypes
{
    partial class frmSpaceShipsTypesMant
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
            this.lblFiliation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.swtxtCategory = new CustomControls.SWTextBox();
            this.swtxtFiliation = new CustomControls.SWTextBox();
            this.swcodCategory = new CustomControls.SWCodi();
            this.swcodFiliation = new CustomControls.SWCodi();
            this.swtxtDesc = new CustomControls.SWTextBox();
            this.swtxtCode = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Location = new System.Drawing.Point(680, 0);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(71, 92);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(41, 17);
            this.lblCode.TabIndex = 26;
            this.lblCode.Text = "Code";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(289, 97);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(79, 17);
            this.lblDesc.TabIndex = 27;
            this.lblDesc.Text = "Description";
            // 
            // lblFiliation
            // 
            this.lblFiliation.AutoSize = true;
            this.lblFiliation.Location = new System.Drawing.Point(71, 138);
            this.lblFiliation.Name = "lblFiliation";
            this.lblFiliation.Size = new System.Drawing.Size(56, 17);
            this.lblFiliation.TabIndex = 28;
            this.lblFiliation.Text = "Filiation";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(71, 179);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 29;
            this.lblCategory.Text = "Category";
            // 
            // swtxtCategory
            // 
            this.swtxtCategory.codiSW = "swcodCategory";
            this.swtxtCategory.columnName = "idSpaceShipCategory";
            this.swtxtCategory.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtCategory.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCategory.isForeignKey = true;
            this.swtxtCategory.Location = new System.Drawing.Point(280, 179);
            this.swtxtCategory.Name = "swtxtCategory";
            this.swtxtCategory.required = true;
            this.swtxtCategory.Size = new System.Drawing.Size(100, 29);
            this.swtxtCategory.TabIndex = 31;
            // 
            // swtxtFiliation
            // 
            this.swtxtFiliation.codiSW = "swcodFiliation";
            this.swtxtFiliation.columnName = "idFiliation";
            this.swtxtFiliation.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtFiliation.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtFiliation.isForeignKey = true;
            this.swtxtFiliation.Location = new System.Drawing.Point(266, 135);
            this.swtxtFiliation.Name = "swtxtFiliation";
            this.swtxtFiliation.required = true;
            this.swtxtFiliation.Size = new System.Drawing.Size(100, 29);
            this.swtxtFiliation.TabIndex = 30;
            // 
            // swcodCategory
            // 
            this.swcodCategory.classeCS = "SpaceShipsTypes";
            this.swcodCategory.codeName = "CodeSpaceShipCategory";
            this.swcodCategory.controlId = "swtxtCategory";
            this.swcodCategory.descName = "DescSpaceShipCategory";
            this.swcodCategory.formCS = "frmSpaceShipCategoriesSearch";
            this.swcodCategory.Location = new System.Drawing.Point(154, 179);
            this.swcodCategory.Name = "swcodCategory";
            this.swcodCategory.nameId = "idSpaceShipCategory";
            this.swcodCategory.Size = new System.Drawing.Size(394, 27);
            this.swcodCategory.TabIndex = 25;
            this.swcodCategory.tableName = "SpaceShipCategories";
            // 
            // swcodFiliation
            // 
            this.swcodFiliation.classeCS = "SpaceShipsTypes";
            this.swcodFiliation.codeName = "CodeFiliation";
            this.swcodFiliation.controlId = "swtxtFiliation";
            this.swcodFiliation.descName = "DescFiliations";
            this.swcodFiliation.formCS = "frmFiliationsSearch";
            this.swcodFiliation.Location = new System.Drawing.Point(154, 138);
            this.swcodFiliation.Name = "swcodFiliation";
            this.swcodFiliation.nameId = "idFiliation";
            this.swcodFiliation.Size = new System.Drawing.Size(394, 27);
            this.swcodFiliation.TabIndex = 24;
            this.swcodFiliation.tableName = "Filiations";
            // 
            // swtxtDesc
            // 
            this.swtxtDesc.codiSW = null;
            this.swtxtDesc.columnName = "DescSpaceShipType";
            this.swtxtDesc.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDesc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDesc.isForeignKey = false;
            this.swtxtDesc.Location = new System.Drawing.Point(388, 90);
            this.swtxtDesc.Name = "swtxtDesc";
            this.swtxtDesc.required = true;
            this.swtxtDesc.Size = new System.Drawing.Size(199, 29);
            this.swtxtDesc.TabIndex = 23;
            // 
            // swtxtCode
            // 
            this.swtxtCode.codiSW = null;
            this.swtxtCode.columnName = "CodeSpaceShipType";
            this.swtxtCode.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCode.isForeignKey = false;
            this.swtxtCode.Location = new System.Drawing.Point(154, 90);
            this.swtxtCode.Name = "swtxtCode";
            this.swtxtCode.required = true;
            this.swtxtCode.Size = new System.Drawing.Size(100, 29);
            this.swtxtCode.TabIndex = 22;
            // 
            // frmSpaceShipsTypesMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 613);
            this.Controls.Add(this.swtxtCategory);
            this.Controls.Add(this.swtxtFiliation);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblFiliation);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.swcodCategory);
            this.Controls.Add(this.swcodFiliation);
            this.Controls.Add(this.swtxtDesc);
            this.Controls.Add(this.swtxtCode);
            this.Name = "frmSpaceShipsTypesMant";
            this.Text = "frmSpaceShipsTypesMant";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCode, 0);
            this.Controls.SetChildIndex(this.swtxtDesc, 0);
            this.Controls.SetChildIndex(this.swcodFiliation, 0);
            this.Controls.SetChildIndex(this.swcodCategory, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.lblDesc, 0);
            this.Controls.SetChildIndex(this.lblFiliation, 0);
            this.Controls.SetChildIndex(this.lblCategory, 0);
            this.Controls.SetChildIndex(this.swtxtFiliation, 0);
            this.Controls.SetChildIndex(this.swtxtCategory, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox swtxtCode;
        private CustomControls.SWTextBox swtxtDesc;
        private CustomControls.SWCodi swcodFiliation;
        private CustomControls.SWCodi swcodCategory;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblFiliation;
        private System.Windows.Forms.Label lblCategory;
        private CustomControls.SWTextBox swtxtCategory;
        private CustomControls.SWTextBox swtxtFiliation;
    }
}