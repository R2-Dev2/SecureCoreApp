
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
            this.txtCodeShip = new CustomControls.SWTextBox();
            this.txtDescShip = new CustomControls.SWTextBox();
            this.lblDescShip = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodeShip
            // 
            this.txtCodeShip.columnName = null;
            this.txtCodeShip.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.txtCodeShip.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeShip.isForeignKey = false;
            this.txtCodeShip.Location = new System.Drawing.Point(180, 177);
            this.txtCodeShip.Name = "txtCodeShip";
            this.txtCodeShip.required = false;
            this.txtCodeShip.Size = new System.Drawing.Size(278, 41);
            this.txtCodeShip.TabIndex = 22;
            this.txtCodeShip.Tag = "CodeSpaceShipCategory";
            // 
            // txtDescShip
            // 
            this.txtDescShip.columnName = null;
            this.txtDescShip.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.txtDescShip.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescShip.isForeignKey = false;
            this.txtDescShip.Location = new System.Drawing.Point(253, 250);
            this.txtDescShip.Name = "txtDescShip";
            this.txtDescShip.required = false;
            this.txtDescShip.Size = new System.Drawing.Size(278, 41);
            this.txtDescShip.TabIndex = 23;
            this.txtDescShip.Tag = "DescSpaceShipCategory";
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
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(106, 188);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(67, 25);
            this.lblCode.TabIndex = 28;
            this.lblCode.Text = "Code";
            // 
            // frmManSpaceShipCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 958);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblDescShip);
            this.Controls.Add(this.txtDescShip);
            this.Controls.Add(this.txtCodeShip);
            this.Name = "frmManSpaceShipCategories";
            this.Text = "frmManSpaceShipCategories";
            this.Controls.SetChildIndex(this.txtCodeShip, 0);
            this.Controls.SetChildIndex(this.txtDescShip, 0);
            this.Controls.SetChildIndex(this.lblDescShip, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox txtCodeShip;
        private CustomControls.SWTextBox txtDescShip;
        private System.Windows.Forms.Label lblDescShip;
        private System.Windows.Forms.Label lblCode;
    }
}