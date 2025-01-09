
namespace LoginForms
{
    partial class frmValidationWrong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidationWrong));
            this.lblWarning = new System.Windows.Forms.Label();
            this.tmrWarning = new System.Windows.Forms.Timer(this.components);
            this.lblDeath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Bernard MT Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWarning.Location = new System.Drawing.Point(2, 92);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(2925, 78);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "INTRUDER DETECTED ";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDeath
            // 
            this.lblDeath.BackColor = System.Drawing.Color.Transparent;
            this.lblDeath.Font = new System.Drawing.Font("Bernard MT Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeath.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeath.Location = new System.Drawing.Point(2, 238);
            this.lblDeath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeath.Name = "lblDeath";
            this.lblDeath.Size = new System.Drawing.Size(2925, 78);
            this.lblDeath.TabIndex = 1;
            this.lblDeath.Text = "GET OUT OR DEATH WILL FOLLOW";
            this.lblDeath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmValidationWrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::LoginForms.Properties.Resources.darth_vader_scary;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.lblDeath);
            this.Controls.Add(this.lblWarning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmValidationWrong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmValidationWrong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmValidationWrong_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Timer tmrWarning;
        private System.Windows.Forms.Label lblDeath;
    }
}