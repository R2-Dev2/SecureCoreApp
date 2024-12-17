
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
            this.swTextBox1 = new CustomControls.SWTextBox();
            this.swTextBox2 = new CustomControls.SWTextBox();
            this.lblDescShip = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // swTextBox1
            // 
            this.swTextBox1.columnName = null;
            this.swTextBox1.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox1.isForeignKey = false;
            this.swTextBox1.Location = new System.Drawing.Point(180, 177);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.opcionalDada = false;
            this.swTextBox1.required = false;
            this.swTextBox1.Size = new System.Drawing.Size(278, 41);
            this.swTextBox1.TabIndex = 22;
            this.swTextBox1.Tag = "CodeSpaceShipCategory";
            // 
            // swTextBox2
            // 
            this.swTextBox2.columnName = null;
            this.swTextBox2.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox2.isForeignKey = false;
            this.swTextBox2.Location = new System.Drawing.Point(253, 250);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.opcionalDada = false;
            this.swTextBox2.required = false;
            this.swTextBox2.Size = new System.Drawing.Size(278, 41);
            this.swTextBox2.TabIndex = 23;
            this.swTextBox2.Tag = "DescSpaceShipCategory";
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
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
            this.Name = "frmManSpaceShipCategories";
            this.Text = "frmManSpaceShipCategories";
            this.Controls.SetChildIndex(this.swTextBox1, 0);
            this.Controls.SetChildIndex(this.swTextBox2, 0);
            this.Controls.SetChildIndex(this.lblDescShip, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox swTextBox1;
        private CustomControls.SWTextBox swTextBox2;
        private System.Windows.Forms.Label lblDescShip;
        private System.Windows.Forms.Label lblCode;
    }
}