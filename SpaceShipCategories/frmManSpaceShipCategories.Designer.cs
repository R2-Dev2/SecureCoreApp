
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
            this.swCodeShip.Location = new System.Drawing.Point(180, 177);
            this.swCodeShip.Name = "swCodeShip";
            this.swCodeShip.required = false;
            this.swCodeShip.Size = new System.Drawing.Size(278, 41);
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
            this.swDescShip.Location = new System.Drawing.Point(253, 250);
            this.swDescShip.Name = "swDescShip";
            this.swDescShip.required = false;
            this.swDescShip.Size = new System.Drawing.Size(278, 41);
            this.swDescShip.TabIndex = 23;
            this.swDescShip.Tag = "DescSpaceShipCategory";
            // 
            // lblDescShip
            // 
            this.lblDescShip.AutoSize = true;
            this.lblDescShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescShip.Location = new System.Drawing.Point(106, 261);
            this.lblDescShip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescShip.Name = "lblDescShip";
            this.lblDescShip.Size = new System.Drawing.Size(131, 25);
            this.lblDescShip.TabIndex = 27;
            this.lblDescShip.Text = "Description";
            // 
            // lblCodeShip
            // 
            this.lblCodeShip.AutoSize = true;
            this.lblCodeShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeShip.Location = new System.Drawing.Point(106, 188);
            this.lblCodeShip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeShip.Name = "lblCodeShip";
            this.lblCodeShip.Size = new System.Drawing.Size(67, 25);
            this.lblCodeShip.TabIndex = 28;
            this.lblCodeShip.Text = "Code";
            // 
            // frmManSpaceShipCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 958);
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