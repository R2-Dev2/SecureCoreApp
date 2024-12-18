
namespace UserRanks
{
    partial class frmManUserRanks
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
            this.lblDescShip = new System.Windows.Forms.Label();
            this.txtDescUserRank = new CustomControls.SWTextBox();
            this.txtCodeUserRank = new CustomControls.SWTextBox();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(104, 211);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(67, 25);
            this.lblCode.TabIndex = 32;
            this.lblCode.Text = "Code";
            // 
            // lblDescShip
            // 
            this.lblDescShip.AutoSize = true;
            this.lblDescShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescShip.Location = new System.Drawing.Point(104, 284);
            this.lblDescShip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescShip.Name = "lblDescShip";
            this.lblDescShip.Size = new System.Drawing.Size(131, 25);
            this.lblDescShip.TabIndex = 31;
            this.lblDescShip.Text = "Description";
            // 
            // txtDescUserRank
            // 
            this.txtDescUserRank.columnName = null;
            this.txtDescUserRank.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.txtDescUserRank.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescUserRank.isForeignKey = false;
            this.txtDescUserRank.Location = new System.Drawing.Point(251, 273);
            this.txtDescUserRank.Name = "txtDescUserRank";
            this.txtDescUserRank.opcionalDada = false;
            this.txtDescUserRank.required = false;
            this.txtDescUserRank.Size = new System.Drawing.Size(278, 41);
            this.txtDescUserRank.TabIndex = 30;
            this.txtDescUserRank.Tag = "DescRank";
            // 
            // txtCodeUserRank
            // 
            this.txtCodeUserRank.columnName = null;
            this.txtCodeUserRank.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.txtCodeUserRank.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeUserRank.isForeignKey = false;
            this.txtCodeUserRank.Location = new System.Drawing.Point(178, 200);
            this.txtCodeUserRank.Name = "txtCodeUserRank";
            this.txtCodeUserRank.opcionalDada = false;
            this.txtCodeUserRank.required = false;
            this.txtCodeUserRank.Size = new System.Drawing.Size(278, 41);
            this.txtCodeUserRank.TabIndex = 29;
            this.txtCodeUserRank.Tag = "CodeRank";
            // 
            // frmManUserRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 954);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblDescShip);
            this.Controls.Add(this.txtDescUserRank);
            this.Controls.Add(this.txtCodeUserRank);
            this.Name = "frmManUserRanks";
            this.Text = "frmManUserRanks";
            this.Controls.SetChildIndex(this.txtCodeUserRank, 0);
            this.Controls.SetChildIndex(this.txtDescUserRank, 0);
            this.Controls.SetChildIndex(this.lblDescShip, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDescShip;
        private CustomControls.SWTextBox txtDescUserRank;
        private CustomControls.SWTextBox txtCodeUserRank;
    }
}