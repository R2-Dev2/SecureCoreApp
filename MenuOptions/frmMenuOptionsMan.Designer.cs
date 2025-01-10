
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
            this.pbClose.Location = new System.Drawing.Point(775, 0);
            // 
            // swtxtNamespace
            // 
            this.swtxtNamespace.codiSW = null;
            this.swtxtNamespace.columnName = "namespace";
            this.swtxtNamespace.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtNamespace.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtNamespace.isForeignKey = false;
            this.swtxtNamespace.Location = new System.Drawing.Point(178, 281);
            this.swtxtNamespace.Name = "swtxtNamespace";
            this.swtxtNamespace.required = true;
            this.swtxtNamespace.Size = new System.Drawing.Size(225, 29);
            this.swtxtNamespace.TabIndex = 4;
            // 
            // swtxtTableName
            // 
            this.swtxtTableName.codiSW = null;
            this.swtxtTableName.columnName = "tableName";
            this.swtxtTableName.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtTableName.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtTableName.isForeignKey = false;
            this.swtxtTableName.Location = new System.Drawing.Point(178, 188);
            this.swtxtTableName.Name = "swtxtTableName";
            this.swtxtTableName.required = true;
            this.swtxtTableName.Size = new System.Drawing.Size(225, 29);
            this.swtxtTableName.TabIndex = 2;
            // 
            // swtxtFormName
            // 
            this.swtxtFormName.codiSW = null;
            this.swtxtFormName.columnName = "formName";
            this.swtxtFormName.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtFormName.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtFormName.isForeignKey = false;
            this.swtxtFormName.Location = new System.Drawing.Point(178, 142);
            this.swtxtFormName.Name = "swtxtFormName";
            this.swtxtFormName.required = true;
            this.swtxtFormName.Size = new System.Drawing.Size(225, 29);
            this.swtxtFormName.TabIndex = 1;
            // 
            // swtxtDescription
            // 
            this.swtxtDescription.codiSW = null;
            this.swtxtDescription.columnName = "description";
            this.swtxtDescription.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDescription.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDescription.isForeignKey = false;
            this.swtxtDescription.Location = new System.Drawing.Point(178, 97);
            this.swtxtDescription.Name = "swtxtDescription";
            this.swtxtDescription.required = true;
            this.swtxtDescription.Size = new System.Drawing.Size(225, 29);
            this.swtxtDescription.TabIndex = 0;
            // 
            // swtxtRangeOption
            // 
            this.swtxtRangeOption.codiSW = null;
            this.swtxtRangeOption.columnName = "rangeOption";
            this.swtxtRangeOption.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtRangeOption.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtRangeOption.isForeignKey = false;
            this.swtxtRangeOption.Location = new System.Drawing.Point(178, 233);
            this.swtxtRangeOption.Name = "swtxtRangeOption";
            this.swtxtRangeOption.required = true;
            this.swtxtRangeOption.Size = new System.Drawing.Size(225, 29);
            this.swtxtRangeOption.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(57, 101);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 20);
            this.lblDescription.TabIndex = 24;
            this.lblDescription.Text = "Description";
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblFormName.Location = new System.Drawing.Point(58, 146);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(99, 20);
            this.lblFormName.TabIndex = 26;
            this.lblFormName.Text = "Form Name";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTableName.Location = new System.Drawing.Point(56, 192);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(101, 20);
            this.lblTableName.TabIndex = 28;
            this.lblTableName.Text = "Table Name";
            // 
            // lblRangeOption
            // 
            this.lblRangeOption.Location = new System.Drawing.Point(0, 0);
            this.lblRangeOption.Name = "lblRangeOption";
            this.lblRangeOption.Size = new System.Drawing.Size(100, 23);
            this.lblRangeOption.TabIndex = 31;
            // 
            // lblNamespace
            // 
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNamespace.Location = new System.Drawing.Point(59, 285);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(98, 20);
            this.lblNamespace.TabIndex = 30;
            this.lblNamespace.Text = "Namespace";
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.AutoSize = true;
            this.lblAccessLevel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblAccessLevel.Location = new System.Drawing.Point(51, 237);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(106, 20);
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
            this.swtxtImage.Location = new System.Drawing.Point(487, 281);
            this.swtxtImage.Name = "swtxtImage";
            this.swtxtImage.required = false;
            this.swtxtImage.Size = new System.Drawing.Size(243, 29);
            this.swtxtImage.TabIndex = 5;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(532, 112);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(150, 150);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 34;
            this.pbImage.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblImage.Location = new System.Drawing.Point(424, 285);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(57, 20);
            this.lblImage.TabIndex = 35;
            this.lblImage.Text = "Image";
            // 
            // frmMenuOptionsMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 686);
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