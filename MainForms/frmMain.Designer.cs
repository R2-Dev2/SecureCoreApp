
namespace MainForms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.imlButtons = new System.Windows.Forms.ImageList(this.components);
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblUsuari = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPpal = new System.Windows.Forms.Panel();
            this.pbUsari = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // imlButtons
            // 
            this.imlButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButtons.ImageStream")));
            this.imlButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButtons.Images.SetKeyName(0, "lightsaber.png");
            this.imlButtons.Images.SetKeyName(1, "login.png");
            this.imlButtons.Images.SetKeyName(2, "module.png");
            this.imlButtons.Images.SetKeyName(3, "rocket.png");
            this.imlButtons.Images.SetKeyName(4, "species.png");
            this.imlButtons.Images.SetKeyName(5, "users.png");
            // 
            // pnlStatus
            // 
            this.pnlStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlStatus.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlStatus.Controls.Add(this.pbUsari);
            this.pnlStatus.Controls.Add(this.pbClose);
            this.pnlStatus.Controls.Add(this.lblUsuari);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1320, 94);
            this.pnlStatus.TabIndex = 2;
            // 
            // lblUsuari
            // 
            this.lblUsuari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuari.BackColor = System.Drawing.Color.DarkCyan;
            this.lblUsuari.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.lblUsuari.Location = new System.Drawing.Point(1023, 0);
            this.lblUsuari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuari.Name = "lblUsuari";
            this.lblUsuari.Size = new System.Drawing.Size(198, 94);
            this.lblUsuari.TabIndex = 0;
            this.lblUsuari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsuari.Click += new System.EventHandler(this.lblUsuari_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMenu.Location = new System.Drawing.Point(0, 94);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(420, 698);
            this.pnlMenu.TabIndex = 3;
            this.pnlMenu.WrapContents = false;
            // 
            // pnlPpal
            // 
            this.pnlPpal.BackgroundImage = global::MainForms.Properties.Resources.PanelLogo;
            this.pnlPpal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPpal.CausesValidation = false;
            this.pnlPpal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPpal.Location = new System.Drawing.Point(420, 94);
            this.pnlPpal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPpal.Name = "pnlPpal";
            this.pnlPpal.Size = new System.Drawing.Size(900, 698);
            this.pnlPpal.TabIndex = 1;
            // 
            // pbUsari
            // 
            this.pbUsari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUsari.BackColor = System.Drawing.Color.DarkCyan;
            this.pbUsari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbUsari.Image = global::MainForms.Properties.Resources.userImg;
            this.pbUsari.Location = new System.Drawing.Point(924, 0);
            this.pbUsari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbUsari.Name = "pbUsari";
            this.pbUsari.Size = new System.Drawing.Size(90, 94);
            this.pbUsari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsari.TabIndex = 3;
            this.pbUsari.TabStop = false;
            this.pbUsari.Click += new System.EventHandler(this.pbUsari_Click);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbClose.Image = global::MainForms.Properties.Resources.icon_cerrar_ventana;
            this.pbClose.Location = new System.Drawing.Point(1230, 0);
            this.pbClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(90, 94);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 792);
            this.Controls.Add(this.pnlPpal);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Core App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lblUsuari;
        private System.Windows.Forms.ImageList imlButtons;
        private System.Windows.Forms.FlowLayoutPanel pnlMenu;
        private System.Windows.Forms.Panel pnlPpal;
        private System.Windows.Forms.PictureBox pbUsari;
    }
}