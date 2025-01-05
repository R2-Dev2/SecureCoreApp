
namespace SpaceShipCategories
{
    partial class frmManSpaceShipCategories
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
            this.swCodeShip = new CustomControls.SWTextBox();
            this.swDescShip = new CustomControls.SWTextBox();
            this.lblDescShip = new System.Windows.Forms.Label();
            this.lblCodeShip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // swCodeShip
            // 
            this.swCodeShip.codiSW = null;
            this.swCodeShip.columnName = "CodeSpaceShipCategory";
            this.swCodeShip.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swCodeShip.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swCodeShip.isForeignKey = false;
            this.swCodeShip.Location = new System.Drawing.Point(125, 113);
            this.swCodeShip.Name = "swCodeShip";
            this.swCodeShip.required = true;
            this.swCodeShip.Size = new System.Drawing.Size(187, 29);
            this.swCodeShip.TabIndex = 22;
            this.swCodeShip.Tag = "CodeSpaceShipCategory";
            // 
            // swDescShip
            // 
            this.swDescShip.codiSW = null;
            this.swDescShip.columnName = "DescSpaceShipCategory";
            this.swDescShip.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swDescShip.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swDescShip.isForeignKey = false;
            this.swDescShip.Location = new System.Drawing.Point(177, 160);
            this.swDescShip.Name = "swDescShip";
            this.swDescShip.required = false;
            this.swDescShip.Size = new System.Drawing.Size(187, 29);
            this.swDescShip.TabIndex = 23;
            this.swDescShip.Tag = "DescSpaceShipCategory";
            // 
            // lblDescShip
            // 
            this.lblDescShip.AutoSize = true;
            this.lblDescShip.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescShip.Location = new System.Drawing.Point(71, 167);
            this.lblDescShip.Name = "lblDescShip";
            this.lblDescShip.Size = new System.Drawing.Size(100, 20);
            this.lblDescShip.TabIndex = 27;
            this.lblDescShip.Text = "Description";
            // 
            // lblCodeShip
            // 
            this.lblCodeShip.AutoSize = true;
            this.lblCodeShip.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeShip.Location = new System.Drawing.Point(71, 120);
            this.lblCodeShip.Name = "lblCodeShip";
            this.lblCodeShip.Size = new System.Drawing.Size(48, 20);
            this.lblCodeShip.TabIndex = 28;
            this.lblCodeShip.Text = "Code";
            // 
            // frmManSpaceShipCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 706);
            this.Controls.Add(this.lblCodeShip);
            this.Controls.Add(this.lblDescShip);
            this.Controls.Add(this.swDescShip);
            this.Controls.Add(this.swCodeShip);
            this.Name = "frmManSpaceShipCategories";
            this.Text = "frmManSpaceShipCategories";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swCodeShip, 0);
            this.Controls.SetChildIndex(this.swDescShip, 0);
            this.Controls.SetChildIndex(this.lblDescShip, 0);
            this.Controls.SetChildIndex(this.lblCodeShip, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox swCodeShip;
        private CustomControls.SWTextBox swDescShip;
        private System.Windows.Forms.Label lblDescShip;
        private System.Windows.Forms.Label lblCodeShip;
    }
}