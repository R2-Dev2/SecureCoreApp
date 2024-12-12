
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblIncorrect.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(102, 353);
            this.lblIncorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(328, 34);
            this.lblIncorrect.TabIndex = 16;
            this.lblIncorrect.Text = "Passwords do not match!!";
            this.lblIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIncorrect.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(102, 426);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(257, 58);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Change password";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(102, 167);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(337, 41);
            this.txtPwd.TabIndex = 14;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPwd.Location = new System.Drawing.Point(101, 116);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(232, 37);
            this.lblPwd.TabIndex = 12;
            this.lblPwd.Text = "New password";
            // 
            // txtPasswordValidacio
            // 
            this.txtPasswordValidacio.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordValidacio.Location = new System.Drawing.Point(102, 289);
            this.txtPasswordValidacio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPasswordValidacio.Name = "txtPasswordValidacio";
            this.txtPasswordValidacio.Size = new System.Drawing.Size(337, 41);
            this.txtPasswordValidacio.TabIndex = 21;
            this.txtPasswordValidacio.UseSystemPasswordChar = true;
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.BackColor = System.Drawing.Color.Transparent;
            this.lblRepeat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRepeat.Location = new System.Drawing.Point(101, 247);
            this.lblRepeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(338, 37);
            this.lblRepeat.TabIndex = 20;
            this.lblRepeat.Text = "Repeat new password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LoginForms.Properties.Resources.FonsLogin;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LoginForms.Properties.Resources.FonsLogin;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(940, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmLoginChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForms.Properties.Resources.FonsLogin;
            this.ClientSize = new System.Drawing.Size(940, 601);
            this.Controls.Add(this.txtPasswordValidacio);
            this.Controls.Add(this.lblRepeat);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginChangePasscs";
            this.Load += new System.EventHandler(this.frmLoginChangePass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}