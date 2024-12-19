
namespace LoginForms
{
    partial class frmLoginChangePass
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
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPasswordValidacio = new System.Windows.Forms.TextBox();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblIncorrect.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(76, 282);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(253, 26);
            this.lblIncorrect.TabIndex = 16;
            this.lblIncorrect.Text = "Passwords do not match!!";
            this.lblIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIncorrect.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(76, 341);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(193, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Change password";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(76, 134);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(254, 33);
            this.txtPwd.TabIndex = 0;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPwd.Location = new System.Drawing.Point(76, 93);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(171, 28);
            this.lblPwd.TabIndex = 12;
            this.lblPwd.Text = "New password";
            // 
            // txtPasswordValidacio
            // 
            this.txtPasswordValidacio.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordValidacio.Location = new System.Drawing.Point(76, 231);
            this.txtPasswordValidacio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordValidacio.Name = "txtPasswordValidacio";
            this.txtPasswordValidacio.Size = new System.Drawing.Size(254, 33);
            this.txtPasswordValidacio.TabIndex = 1;
            this.txtPasswordValidacio.UseSystemPasswordChar = true;
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.BackColor = System.Drawing.Color.Transparent;
            this.lblRepeat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRepeat.Location = new System.Drawing.Point(76, 198);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(252, 28);
            this.lblRepeat.TabIndex = 20;
            this.lblRepeat.Text = "Repeat new password";
            // 
            // pbBackground
            // 
            this.pbBackground.BackgroundImage = global::LoginForms.Properties.Resources.FonsLogin;
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackground.Image = global::LoginForms.Properties.Resources.FonsLogin;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(705, 481);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 22;
            this.pbBackground.TabStop = false;
            // 
            // frmLoginChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForms.Properties.Resources.FonsLogin;
            this.ClientSize = new System.Drawing.Size(705, 481);
            this.Controls.Add(this.txtPasswordValidacio);
            this.Controls.Add(this.lblRepeat);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.pbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLoginChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginChangePasscs";
            this.Load += new System.EventHandler(this.frmLoginChangePass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPasswordValidacio;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.PictureBox pbBackground;
    }
}