
namespace LoginForms
{
    partial class frmSplash
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Percentatge = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pctboxPistola = new System.Windows.Forms.PictureBox();
            this.pbProgress = new System.Windows.Forms.PictureBox();
            this.pctboxBackground = new System.Windows.Forms.PictureBox();
            this.pbProgress2 = new System.Windows.Forms.PictureBox();
            this.pbProgress3 = new System.Windows.Forms.PictureBox();
            this.pbProgress4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxPistola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress4)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(157, 322);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(429, 23);
            this.progressBar.TabIndex = 0;
            this.progressBar.Visible = false;
            // 
            // Percentatge
            // 
            this.Percentatge.AutoSize = true;
            this.Percentatge.BackColor = System.Drawing.Color.Transparent;
            this.Percentatge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentatge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Percentatge.Location = new System.Drawing.Point(347, 369);
            this.Percentatge.Name = "Percentatge";
            this.Percentatge.Size = new System.Drawing.Size(35, 20);
            this.Percentatge.TabIndex = 1;
            this.Percentatge.Text = "0%";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pctboxPistola
            // 
            this.pctboxPistola.BackColor = System.Drawing.Color.Transparent;
            this.pctboxPistola.Image = global::LoginForms.Properties.Resources.pistolaLaserEdit;
            this.pctboxPistola.Location = new System.Drawing.Point(42, 294);
            this.pctboxPistola.Name = "pctboxPistola";
            this.pctboxPistola.Size = new System.Drawing.Size(123, 92);
            this.pctboxPistola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctboxPistola.TabIndex = 2;
            this.pctboxPistola.TabStop = false;
            // 
            // pbProgress
            // 
            this.pbProgress.BackColor = System.Drawing.Color.Transparent;
            this.pbProgress.Image = global::LoginForms.Properties.Resources.projectilLaserEditat;
            this.pbProgress.Location = new System.Drawing.Point(171, 304);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(113, 50);
            this.pbProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProgress.TabIndex = 3;
            this.pbProgress.TabStop = false;
            // 
            // pctboxBackground
            // 
            this.pctboxBackground.BackColor = System.Drawing.Color.Transparent;
            this.pctboxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctboxBackground.Image = global::LoginForms.Properties.Resources.SecureCoreSplash;
            this.pctboxBackground.Location = new System.Drawing.Point(0, 0);
            this.pctboxBackground.Name = "pctboxBackground";
            this.pctboxBackground.Size = new System.Drawing.Size(731, 414);
            this.pctboxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctboxBackground.TabIndex = 4;
            this.pctboxBackground.TabStop = false;
            // 
            // pbProgress2
            // 
            this.pbProgress2.BackColor = System.Drawing.Color.Transparent;
            this.pbProgress2.Image = global::LoginForms.Properties.Resources.projectilLaserEditat;
            this.pbProgress2.Location = new System.Drawing.Point(290, 304);
            this.pbProgress2.Name = "pbProgress2";
            this.pbProgress2.Size = new System.Drawing.Size(103, 50);
            this.pbProgress2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProgress2.TabIndex = 5;
            this.pbProgress2.TabStop = false;
            this.pbProgress2.Visible = false;
            // 
            // pbProgress3
            // 
            this.pbProgress3.BackColor = System.Drawing.Color.Transparent;
            this.pbProgress3.Image = global::LoginForms.Properties.Resources.projectilLaserEditat;
            this.pbProgress3.Location = new System.Drawing.Point(399, 304);
            this.pbProgress3.Name = "pbProgress3";
            this.pbProgress3.Size = new System.Drawing.Size(103, 50);
            this.pbProgress3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProgress3.TabIndex = 6;
            this.pbProgress3.TabStop = false;
            this.pbProgress3.Visible = false;
            // 
            // pbProgress4
            // 
            this.pbProgress4.BackColor = System.Drawing.Color.Transparent;
            this.pbProgress4.Image = global::LoginForms.Properties.Resources.projectilLaserEditat;
            this.pbProgress4.Location = new System.Drawing.Point(509, 304);
            this.pbProgress4.Name = "pbProgress4";
            this.pbProgress4.Size = new System.Drawing.Size(103, 50);
            this.pbProgress4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProgress4.TabIndex = 7;
            this.pbProgress4.TabStop = false;
            this.pbProgress4.Visible = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForms.Properties.Resources.SecureCoreSplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 414);
            this.Controls.Add(this.pbProgress4);
            this.Controls.Add(this.pbProgress3);
            this.Controls.Add(this.pbProgress2);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.pctboxPistola);
            this.Controls.Add(this.Percentatge);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pctboxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pctboxPistola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label Percentatge;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pctboxPistola;
        private System.Windows.Forms.PictureBox pbProgress;
        private System.Windows.Forms.PictureBox pctboxBackground;
        private System.Windows.Forms.PictureBox pbProgress2;
        private System.Windows.Forms.PictureBox pbProgress3;
        private System.Windows.Forms.PictureBox pbProgress4;
    }
}