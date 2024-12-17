
namespace MainForms
{
    partial class frmSpecies
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
            this.txtDescSpecie = new System.Windows.Forms.TextBox();
            this.txtCodeSpec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // lblDescSpecie
            // 
            this.lblDescSpecie.AutoSize = true;
            this.lblDescSpecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSpecie.Location = new System.Drawing.Point(45, 151);
            this.lblDescSpecie.Name = "lblDescSpecie";
            this.lblDescSpecie.Size = new System.Drawing.Size(90, 17);
            this.lblDescSpecie.TabIndex = 18;
            this.lblDescSpecie.Text = "Description";
            // 
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(78, 106);
            this.lblCodeSpec.Name = "lblCodeSpec";
            this.lblCodeSpec.Size = new System.Drawing.Size(45, 17);
            this.lblCodeSpec.TabIndex = 17;
            this.lblCodeSpec.Text = "Code";
            // 
            // txtDescSpecie
            // 
            this.txtDescSpecie.Location = new System.Drawing.Point(138, 146);
            this.txtDescSpecie.Name = "txtDescSpecie";
            this.txtDescSpecie.Size = new System.Drawing.Size(100, 22);
            this.txtDescSpecie.TabIndex = 16;
            this.txtDescSpecie.Tag = "DescSpecie";
            // 
            // txtCodeSpec
            // 
            this.txtCodeSpec.Location = new System.Drawing.Point(138, 102);
            this.txtCodeSpec.Name = "txtCodeSpec";
            this.txtCodeSpec.Size = new System.Drawing.Size(100, 22);
            this.txtCodeSpec.TabIndex = 15;
            this.txtCodeSpec.Tag = "CodeSpecie";
            // 
            // frmSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 615);
            this.Controls.Add(this.lblDescSpecie);
            this.Controls.Add(this.lblCodeSpec);
            this.Controls.Add(this.txtDescSpecie);
            this.Controls.Add(this.txtCodeSpec);
            this.Name = "frmSpecies";
            this.Text = "frmSpecies";
            this.Controls.SetChildIndex(this.txtCodeSpec, 0);
            this.Controls.SetChildIndex(this.txtDescSpecie, 0);
            this.Controls.SetChildIndex(this.lblCodeSpec, 0);
            this.Controls.SetChildIndex(this.lblDescSpecie, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescSpecie;
        private System.Windows.Forms.Label lblCodeSpec;
        private System.Windows.Forms.TextBox txtDescSpecie;
        private System.Windows.Forms.TextBox txtCodeSpec;
    }
}