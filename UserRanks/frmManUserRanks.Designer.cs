
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
            this.lblCodeUserRank = new System.Windows.Forms.Label();
            this.lblDescUserRank = new System.Windows.Forms.Label();
            this.swDescUserRank = new CustomControls.SWTextBox();
            this.swCodeUserRank = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeUserRank
            // 
            this.lblCodeUserRank.AutoSize = true;
            this.lblCodeUserRank.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeUserRank.Location = new System.Drawing.Point(103, 219);
            this.lblCodeUserRank.Name = "lblCodeUserRank";
            this.lblCodeUserRank.Size = new System.Drawing.Size(48, 20);
            this.lblCodeUserRank.TabIndex = 32;
            this.lblCodeUserRank.Text = "Code";
            // 
            // lblDescUserRank
            // 
            this.lblDescUserRank.AutoSize = true;
            this.lblDescUserRank.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescUserRank.Location = new System.Drawing.Point(51, 272);
            this.lblDescUserRank.Name = "lblDescUserRank";
            this.lblDescUserRank.Size = new System.Drawing.Size(100, 20);
            this.lblDescUserRank.TabIndex = 31;
            this.lblDescUserRank.Text = "Description";
            // 
            // swDescUserRank
            // 
            this.swDescUserRank.codiSW = null;
            this.swDescUserRank.columnName = "DescRank";
            this.swDescUserRank.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swDescUserRank.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swDescUserRank.isForeignKey = false;
            this.swDescUserRank.Location = new System.Drawing.Point(166, 268);
            this.swDescUserRank.Name = "swDescUserRank";
            this.swDescUserRank.required = false;
            this.swDescUserRank.Size = new System.Drawing.Size(272, 29);
            this.swDescUserRank.TabIndex = 30;
            this.swDescUserRank.Tag = "DescRank";
            // 
            // swCodeUserRank
            // 
            this.swCodeUserRank.codiSW = null;
            this.swCodeUserRank.columnName = "CodeRank";
            this.swCodeUserRank.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swCodeUserRank.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swCodeUserRank.isForeignKey = false;
            this.swCodeUserRank.Location = new System.Drawing.Point(166, 215);
            this.swCodeUserRank.Name = "swCodeUserRank";
            this.swCodeUserRank.required = true;
            this.swCodeUserRank.Size = new System.Drawing.Size(187, 29);
            this.swCodeUserRank.TabIndex = 29;
            this.swCodeUserRank.Tag = "CodeRank";
            // 
            // frmManUserRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 706);
            this.Controls.Add(this.lblCodeUserRank);
            this.Controls.Add(this.lblDescUserRank);
            this.Controls.Add(this.swDescUserRank);
            this.Controls.Add(this.swCodeUserRank);
            this.Name = "frmManUserRanks";
            this.Text = "frmManUserRanks";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swCodeUserRank, 0);
            this.Controls.SetChildIndex(this.swDescUserRank, 0);
            this.Controls.SetChildIndex(this.lblDescUserRank, 0);
            this.Controls.SetChildIndex(this.lblCodeUserRank, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeUserRank;
        private System.Windows.Forms.Label lblDescUserRank;
        private CustomControls.SWTextBox swCodeUserRank;
        private CustomControls.SWTextBox swDescUserRank;
    }
}