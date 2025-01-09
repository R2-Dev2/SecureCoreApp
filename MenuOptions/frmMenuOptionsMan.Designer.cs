
namespace MenuOptions
{
    partial class frmMenuOptionsMan
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
            this.swtxtNamespace = new CustomControls.SWTextBox();
            this.swtxtTableName = new CustomControls.SWTextBox();
            this.swtxtFormName = new CustomControls.SWTextBox();
            this.swtxtDescription = new CustomControls.SWTextBox();
            this.swtxtRangeOption = new CustomControls.SWTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.lblRangeOption = new System.Windows.Forms.Label();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.lblAccessLevel = new System.Windows.Forms.Label();
            this.swtxtImage = new CustomControls.SWTextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Location = new System.Drawing.Point(1162, 0);
            // 
            // swtxtNamespace
            // 
            this.swtxtNamespace.codiSW = null;
            this.swtxtNamespace.columnName = "namespace";
            this.swtxtNamespace.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtNamespace.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtNamespace.isForeignKey = false;
            this.swtxtNamespace.Location = new System.Drawing.Point(267, 439);
            this.swtxtNamespace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtNamespace.Name = "swtxtNamespace";
            this.swtxtNamespace.required = true;
            this.swtxtNamespace.Size = new System.Drawing.Size(336, 41);
            this.swtxtNamespace.TabIndex = 23;
            // 
            // swtxtTableName
            // 
            this.swtxtTableName.codiSW = null;
            this.swtxtTableName.columnName = "tableName";
            this.swtxtTableName.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtTableName.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtTableName.isForeignKey = false;
            this.swtxtTableName.Location = new System.Drawing.Point(267, 294);
            this.swtxtTableName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtTableName.Name = "swtxtTableName";
            this.swtxtTableName.required = true;
            this.swtxtTableName.Size = new System.Drawing.Size(336, 41);
            this.swtxtTableName.TabIndex = 2;
            // 
            // swtxtFormName
            // 
            this.swtxtFormName.codiSW = null;
            this.swtxtFormName.columnName = "formName";
            this.swtxtFormName.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtFormName.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtFormName.isForeignKey = false;
            this.swtxtFormName.Location = new System.Drawing.Point(267, 222);
            this.swtxtFormName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtFormName.Name = "swtxtFormName";
            this.swtxtFormName.required = true;
            this.swtxtFormName.Size = new System.Drawing.Size(336, 41);
            this.swtxtFormName.TabIndex = 0;
            // 
            // swtxtDescription
            // 
            this.swtxtDescription.codiSW = null;
            this.swtxtDescription.columnName = "description";
            this.swtxtDescription.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDescription.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDescription.isForeignKey = false;
            this.swtxtDescription.Location = new System.Drawing.Point(267, 152);
            this.swtxtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtDescription.Name = "swtxtDescription";
            this.swtxtDescription.required = true;
            this.swtxtDescription.Size = new System.Drawing.Size(336, 41);
            this.swtxtDescription.TabIndex = 0;
            // 
            // swtxtRangeOption
            // 
            this.swtxtRangeOption.codiSW = null;
            this.swtxtRangeOption.columnName = "rangeOption";
            this.swtxtRangeOption.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtRangeOption.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtRangeOption.isForeignKey = false;
            this.swtxtRangeOption.Location = new System.Drawing.Point(267, 364);
            this.swtxtRangeOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtRangeOption.Name = "swtxtRangeOption";
            this.swtxtRangeOption.required = true;
            this.swtxtRangeOption.Size = new System.Drawing.Size(336, 41);
            this.swtxtRangeOption.TabIndex = 23;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(86, 158);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(167, 33);
            this.lblDescription.TabIndex = 24;
            this.lblDescription.Text = "Description";
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblFormName.Location = new System.Drawing.Point(87, 228);
            this.lblFormName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(163, 33);
            this.lblFormName.TabIndex = 26;
            this.lblFormName.Text = "Form Name";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTableName.Location = new System.Drawing.Point(84, 300);
            this.lblTableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(167, 33);
            this.lblTableName.TabIndex = 28;
            this.lblTableName.Text = "Table Name";
            // 
            // lblRangeOption
            // 
            this.lblRangeOption.Location = new System.Drawing.Point(0, 0);
            this.lblRangeOption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRangeOption.Name = "lblRangeOption";
            this.lblRangeOption.Size = new System.Drawing.Size(150, 36);
            this.lblRangeOption.TabIndex = 31;
            // 
            // lblNamespace
            // 
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNamespace.Location = new System.Drawing.Point(88, 445);
            this.lblNamespace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(162, 33);
            this.lblNamespace.TabIndex = 30;
            this.lblNamespace.Text = "Namespace";
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.AutoSize = true;
            this.lblAccessLevel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblAccessLevel.Location = new System.Drawing.Point(76, 370);
            this.lblAccessLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(174, 33);
            this.lblAccessLevel.TabIndex = 32;
            this.lblAccessLevel.Text = "Access Level";
            // 
            // swtxtImage
            // 
            this.swtxtImage.codiSW = null;
            this.swtxtImage.columnName = "image";
            this.swtxtImage.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtImage.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtImage.isForeignKey = false;
            this.swtxtImage.Location = new System.Drawing.Point(730, 439);
            this.swtxtImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtImage.Name = "swtxtImage";
            this.swtxtImage.required = false;
            this.swtxtImage.Size = new System.Drawing.Size(362, 41);
            this.swtxtImage.TabIndex = 33;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(798, 175);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(225, 234);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 34;
            this.pbImage.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblImage.Location = new System.Drawing.Point(636, 445);
            this.lblImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(95, 33);
            this.lblImage.TabIndex = 35;
            this.lblImage.Text = "Image";
            // 
            // frmMenuOptionsMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1072);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.swtxtImage);
            this.Controls.Add(this.lblAccessLevel);
            this.Controls.Add(this.lblNamespace);
            this.Controls.Add(this.lblRangeOption);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.swtxtRangeOption);
            this.Controls.Add(this.swtxtDescription);
            this.Controls.Add(this.swtxtFormName);
            this.Controls.Add(this.swtxtTableName);
            this.Controls.Add(this.swtxtNamespace);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmMenuOptionsMan";
            this.Text = "z";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtNamespace, 0);
            this.Controls.SetChildIndex(this.swtxtTableName, 0);
            this.Controls.SetChildIndex(this.swtxtFormName, 0);
            this.Controls.SetChildIndex(this.swtxtDescription, 0);
            this.Controls.SetChildIndex(this.swtxtRangeOption, 0);
            this.Controls.SetChildIndex(this.lblDescription, 0);
            this.Controls.SetChildIndex(this.lblFormName, 0);
            this.Controls.SetChildIndex(this.lblTableName, 0);
            this.Controls.SetChildIndex(this.lblRangeOption, 0);
            this.Controls.SetChildIndex(this.lblNamespace, 0);
            this.Controls.SetChildIndex(this.lblAccessLevel, 0);
            this.Controls.SetChildIndex(this.swtxtImage, 0);
            this.Controls.SetChildIndex(this.pbImage, 0);
            this.Controls.SetChildIndex(this.lblImage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox swtxtNamespace;
        private CustomControls.SWTextBox swtxtTableName;
        private CustomControls.SWTextBox swtxtFormName;
        private CustomControls.SWTextBox swtxtDescription;
        private CustomControls.SWTextBox swtxtRangeOption;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label lblRangeOption;
        private System.Windows.Forms.Label lblNamespace;
        private System.Windows.Forms.Label lblAccessLevel;
        private CustomControls.SWTextBox swtxtImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblImage;
    }
}