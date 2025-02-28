
namespace UserRanks
{
    partial class frmUserRanksMan
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
            // pbClose
            // 
            // 
            // lblCodeUserRank
            // 
            this.lblCodeUserRank.AutoSize = true;
            this.lblCodeUserRank.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeUserRank.Location = new System.Drawing.Point(154, 342);
            this.lblCodeUserRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeUserRank.Name = "lblCodeUserRank";
            this.lblCodeUserRank.Size = new System.Drawing.Size(79, 33);
            this.lblCodeUserRank.TabIndex = 32;
            this.lblCodeUserRank.Text = "Code";
            // 
            // lblDescUserRank
            // 
            this.lblDescUserRank.AutoSize = true;
            this.lblDescUserRank.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescUserRank.Location = new System.Drawing.Point(76, 425);
            this.lblDescUserRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescUserRank.Name = "lblDescUserRank";
            this.lblDescUserRank.Size = new System.Drawing.Size(167, 33);
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
            this.swDescUserRank.Location = new System.Drawing.Point(249, 419);
            this.swDescUserRank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swDescUserRank.Name = "swDescUserRank";
            this.swDescUserRank.required = false;
            this.swDescUserRank.Size = new System.Drawing.Size(406, 41);
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
            this.swCodeUserRank.Location = new System.Drawing.Point(249, 336);
            this.swCodeUserRank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swCodeUserRank.Name = "swCodeUserRank";
            this.swCodeUserRank.required = true;
            this.swCodeUserRank.Size = new System.Drawing.Size(278, 41);
            this.swCodeUserRank.TabIndex = 29;
            this.swCodeUserRank.Tag = "CodeRank";
            // 
            // frmUserRanksMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 1103);
            this.Controls.Add(this.lblCodeUserRank);
            this.Controls.Add(this.lblDescUserRank);
            this.Controls.Add(this.swDescUserRank);
            this.Controls.Add(this.swCodeUserRank);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmUserRanksMan";
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