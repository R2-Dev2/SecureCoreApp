
namespace UserCategories
{
    partial class frmUserRankSearch
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
            this.swtxtDescRank = new CustomControls.SWTextBox();
            this.swtxtCodeUserRank = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Location = new System.Drawing.Point(1197, 0);
            // 
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(216, 213);
            this.lblCodeSpec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeSpec.Name = "lblCodeSpec";
            this.lblCodeSpec.Size = new System.Drawing.Size(79, 33);
            this.lblCodeSpec.TabIndex = 25;
            this.lblCodeSpec.Text = "Code";
            // 
            // lblDescSpecie
            // 
            this.lblDescSpecie.AutoSize = true;
            this.lblDescSpecie.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSpecie.Location = new System.Drawing.Point(140, 284);
            this.lblDescSpecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescSpecie.Name = "lblDescSpecie";
            this.lblDescSpecie.Size = new System.Drawing.Size(167, 33);
            this.lblDescSpecie.TabIndex = 26;
            this.lblDescSpecie.Text = "Description";
            // 
            // swtxtDescRank
            // 
            this.swtxtDescRank.codiSW = null;
            this.swtxtDescRank.columnName = "DescRank";
            this.swtxtDescRank.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDescRank.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDescRank.isForeignKey = false;
            this.swtxtDescRank.Location = new System.Drawing.Point(315, 279);
            this.swtxtDescRank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtDescRank.Name = "swtxtDescRank";
            this.swtxtDescRank.required = false;
            this.swtxtDescRank.Size = new System.Drawing.Size(148, 41);
            this.swtxtDescRank.TabIndex = 24;
            // 
            // swtxtCodeUserRank
            // 
            this.swtxtCodeUserRank.codiSW = null;
            this.swtxtCodeUserRank.columnName = "CodeRank";
            this.swtxtCodeUserRank.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCodeUserRank.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCodeUserRank.isForeignKey = false;
            this.swtxtCodeUserRank.Location = new System.Drawing.Point(301, 204);
            this.swtxtCodeUserRank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtCodeUserRank.Name = "swtxtCodeUserRank";
            this.swtxtCodeUserRank.required = false;
            this.swtxtCodeUserRank.Size = new System.Drawing.Size(148, 41);
            this.swtxtCodeUserRank.TabIndex = 23;
            // 
            // frmUserRankSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 886);
            this.Controls.Add(this.lblCodeSpec);
            this.Controls.Add(this.lblDescSpecie);
            this.Controls.Add(this.swtxtDescRank);
            this.Controls.Add(this.swtxtCodeUserRank);
            this.Name = "frmUserRankSearch";
            this.Text = "frmUserRankSearch";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCodeUserRank, 0);
            this.Controls.SetChildIndex(this.swtxtDescRank, 0);
            this.Controls.SetChildIndex(this.lblDescSpecie, 0);
            this.Controls.SetChildIndex(this.lblCodeSpec, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeSpec;
        private System.Windows.Forms.Label lblDescSpecie;
        private CustomControls.SWTextBox swtxtDescRank;
        public CustomControls.SWTextBox swtxtCodeUserRank;
    }
}