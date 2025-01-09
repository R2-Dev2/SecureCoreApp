
namespace LoginForms
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblTriesLeft = new System.Windows.Forms.Label();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pbvalidacio = new System.Windows.Forms.PictureBox();
            this.timerValidating = new System.Windows.Forms.Timer(this.components);
            this.lblVerificantNivell = new System.Windows.Forms.Label();
            this.lblBenvinguda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvalidacio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(634, 123);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(164, 37);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "username";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.ForeColor = System.Drawing.Color.White;
            this.lblPwd.Location = new System.Drawing.Point(634, 228);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(160, 37);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "password";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(634, 164);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(240, 41);
            this.txtUser.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(634, 269);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(240, 41);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(682, 442);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 58);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblIncorrect.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(586, 341);
            this.lblIncorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(347, 34);
            this.lblIncorrect.TabIndex = 6;
            this.lblIncorrect.Text = "Incorrect user or password";
            this.lblIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIncorrect.Visible = false;
            // 
            // lblTriesLeft
            // 
            this.lblTriesLeft.AutoSize = true;
            this.lblTriesLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblTriesLeft.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriesLeft.ForeColor = System.Drawing.Color.Red;
            this.lblTriesLeft.Location = new System.Drawing.Point(692, 375);
            this.lblTriesLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTriesLeft.Name = "lblTriesLeft";
            this.lblTriesLeft.Size = new System.Drawing.Size(140, 34);
            this.lblTriesLeft.TabIndex = 9;
            this.lblTriesLeft.Text = "3 tries left";
            this.lblTriesLeft.Visible = false;
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.Color.Transparent;
            this.pbBackground.BackgroundImage = global::LoginForms.Properties.Resources.FonsLogin;
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackground.Image = global::LoginForms.Properties.Resources.FonsLogin;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(994, 650);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 10;
            this.pbBackground.TabStop = false;
            // 
            // pbvalidacio
            // 
            this.pbvalidacio.BackColor = System.Drawing.Color.Transparent;
            this.pbvalidacio.Image = global::LoginForms.Properties.Resources.validacioEstatPrevi;
            this.pbvalidacio.Location = new System.Drawing.Point(105, 208);
            this.pbvalidacio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbvalidacio.Name = "pbvalidacio";
            this.pbvalidacio.Size = new System.Drawing.Size(208, 212);
            this.pbvalidacio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbvalidacio.TabIndex = 11;
            this.pbvalidacio.TabStop = false;
            // 
            // timerValidating
            // 
            this.timerValidating.Interval = 500;
            this.timerValidating.Tick += new System.EventHandler(this.TimerValidating_Tick);
            // 
            // lblVerificantNivell
            // 
            this.lblVerificantNivell.AutoSize = true;
            this.lblVerificantNivell.BackColor = System.Drawing.Color.Transparent;
            this.lblVerificantNivell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblVerificantNivell.ForeColor = System.Drawing.Color.White;
            this.lblVerificantNivell.Location = new System.Drawing.Point(51, 425);
            this.lblVerificantNivell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificantNivell.Name = "lblVerificantNivell";
            this.lblVerificantNivell.Size = new System.Drawing.Size(0, 31);
            this.lblVerificantNivell.TabIndex = 6;
            // 
            // lblBenvinguda
            // 
            this.lblBenvinguda.AutoSize = true;
            this.lblBenvinguda.BackColor = System.Drawing.Color.Transparent;
            this.lblBenvinguda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblBenvinguda.ForeColor = System.Drawing.Color.White;
            this.lblBenvinguda.Location = new System.Drawing.Point(75, 145);
            this.lblBenvinguda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBenvinguda.Name = "lblBenvinguda";
            this.lblBenvinguda.Size = new System.Drawing.Size(0, 36);
            this.lblBenvinguda.TabIndex = 12;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LoginForms.Properties.Resources.FonsLogin;
            this.ClientSize = new System.Drawing.Size(994, 650);
            this.Controls.Add(this.lblBenvinguda);
            this.Controls.Add(this.lblVerificantNivell);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pbvalidacio);
            this.Controls.Add(this.lblTriesLeft);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvalidacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblTriesLeft;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbvalidacio;
        private System.Windows.Forms.Timer timerValidating;
        private System.Windows.Forms.Label lblVerificantNivell;
        private System.Windows.Forms.Label lblBenvinguda;
    }
}