
namespace Planets
{
    partial class frmSpeciesSearch
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
            this.lblDescSpecie = new System.Windows.Forms.Label();
            this.lblCodeSpec = new System.Windows.Forms.Label();
            this.swtxtDescSpec = new CustomControls.SWTextBox();
            this.swtxtCodeSpec = new CustomControls.SWTextBox();
            this.SuspendLayout();
            // 
            // lblDescSpecie
            // 
            this.lblDescSpecie.AutoSize = true;
            this.lblDescSpecie.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSpecie.Location = new System.Drawing.Point(94, 187);
            this.lblDescSpecie.Name = "lblDescSpecie";
            this.lblDescSpecie.Size = new System.Drawing.Size(100, 20);
            this.lblDescSpecie.TabIndex = 20;
            this.lblDescSpecie.Text = "Description";
            // 
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(146, 136);
            this.lblCodeSpec.Name = "lblCodeSpec";
            this.lblCodeSpec.Size = new System.Drawing.Size(48, 20);
            this.lblCodeSpec.TabIndex = 19;
            this.lblCodeSpec.Text = "Code";
            // 
            // swtxtDescSpec
            // 
            this.swtxtDescSpec.columnName = "DescSpecie";
            this.swtxtDescSpec.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDescSpec.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDescSpec.isForeignKey = false;
            this.swtxtDescSpec.Location = new System.Drawing.Point(203, 178);
            this.swtxtDescSpec.Name = "swtxtDescSpec";
            this.swtxtDescSpec.required = false;
            this.swtxtDescSpec.Size = new System.Drawing.Size(100, 29);
            this.swtxtDescSpec.TabIndex = 6;
            // 
            // swtxtCodeSpec
            // 
            this.swtxtCodeSpec.columnName = "CodeSpecie";
            this.swtxtCodeSpec.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCodeSpec.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCodeSpec.isForeignKey = false;
            this.swtxtCodeSpec.Location = new System.Drawing.Point(203, 130);
            this.swtxtCodeSpec.Name = "swtxtCodeSpec";
            this.swtxtCodeSpec.required = false;
            this.swtxtCodeSpec.Size = new System.Drawing.Size(100, 29);
            this.swtxtCodeSpec.TabIndex = 5;
            // 
            // frmSpeciesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 573);
            this.Controls.Add(this.lblCodeSpec);
            this.Controls.Add(this.lblDescSpecie);
            this.Controls.Add(this.swtxtDescSpec);
            this.Controls.Add(this.swtxtCodeSpec);
            this.Name = "frmSpeciesSearch";
            this.Text = "frmSpeciesSearch";
            this.Controls.SetChildIndex(this.swtxtCodeSpec, 0);
            this.Controls.SetChildIndex(this.swtxtDescSpec, 0);
            this.Controls.SetChildIndex(this.lblDescSpecie, 0);
            this.Controls.SetChildIndex(this.lblCodeSpec, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescSpecie;
        private System.Windows.Forms.Label lblCodeSpec;
        private CustomControls.SWTextBox swtxtDescSpec;
        public CustomControls.SWTextBox swtxtCodeSpec;
    }
}