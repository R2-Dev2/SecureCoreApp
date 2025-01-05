
namespace SpaceShipsTypes
{
    partial class frmSpaceShipTypesSearch
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
            this.swtxtDescSpaceShipType = new CustomControls.SWTextBox();
            this.swtxtCodeSpaceShipType = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(91, 137);
            this.lblCodeSpec.Name = "lblCodeSpec";
            this.lblCodeSpec.Size = new System.Drawing.Size(48, 20);
            this.lblCodeSpec.TabIndex = 25;
            this.lblCodeSpec.Text = "Code";
            // 
            // lblDescSpecie
            // 
            this.lblDescSpecie.AutoSize = true;
            this.lblDescSpecie.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSpecie.Location = new System.Drawing.Point(39, 203);
            this.lblDescSpecie.Name = "lblDescSpecie";
            this.lblDescSpecie.Size = new System.Drawing.Size(100, 20);
            this.lblDescSpecie.TabIndex = 26;
            this.lblDescSpecie.Text = "Description";
            // 
            // swtxtDescSpaceShipType
            // 
            this.swtxtDescSpaceShipType.codiSW = null;
            this.swtxtDescSpaceShipType.columnName = "DescSpaceShipType";
            this.swtxtDescSpaceShipType.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDescSpaceShipType.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDescSpaceShipType.isForeignKey = false;
            this.swtxtDescSpaceShipType.Location = new System.Drawing.Point(156, 199);
            this.swtxtDescSpaceShipType.Name = "swtxtDescSpaceShipType";
            this.swtxtDescSpaceShipType.required = false;
            this.swtxtDescSpaceShipType.Size = new System.Drawing.Size(244, 29);
            this.swtxtDescSpaceShipType.TabIndex = 24;
            // 
            // swtxtCodeSpaceShipType
            // 
            this.swtxtCodeSpaceShipType.codiSW = null;
            this.swtxtCodeSpaceShipType.columnName = "CodeSpaceShipType";
            this.swtxtCodeSpaceShipType.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCodeSpaceShipType.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCodeSpaceShipType.isForeignKey = false;
            this.swtxtCodeSpaceShipType.Location = new System.Drawing.Point(156, 133);
            this.swtxtCodeSpaceShipType.Name = "swtxtCodeSpaceShipType";
            this.swtxtCodeSpaceShipType.required = false;
            this.swtxtCodeSpaceShipType.Size = new System.Drawing.Size(158, 29);
            this.swtxtCodeSpaceShipType.TabIndex = 23;
            // 
            // frmSpaceShipTypesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 633);
            this.Controls.Add(this.lblCodeSpec);
            this.Controls.Add(this.lblDescSpecie);
            this.Controls.Add(this.swtxtDescSpaceShipType);
            this.Controls.Add(this.swtxtCodeSpaceShipType);
            this.Name = "frmSpaceShipTypesSearch";
            this.Text = "frmSpaceShipTypesSearch";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCodeSpaceShipType, 0);
            this.Controls.SetChildIndex(this.swtxtDescSpaceShipType, 0);
            this.Controls.SetChildIndex(this.lblDescSpecie, 0);
            this.Controls.SetChildIndex(this.lblCodeSpec, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeSpec;
        private System.Windows.Forms.Label lblDescSpecie;
        private CustomControls.SWTextBox swtxtDescSpaceShipType;
        private CustomControls.SWTextBox swtxtCodeSpaceShipType;
    }
}