
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
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.pbUsari = new System.Windows.Forms.PictureBox();
            this.lblUsuari = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSpecies = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pnlPpal = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlStatus.SuspendLayout();
            this.gbUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.pnlMenu.SuspendLayout();
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
            this.pnlStatus.Controls.Add(this.gbUserInfo);
            this.pnlStatus.Controls.Add(this.pbClose);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(990, 48);
            this.pnlStatus.TabIndex = 2;
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUserInfo.BackColor = System.Drawing.Color.Teal;
            this.gbUserInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbUserInfo.Controls.Add(this.pbUsari);
            this.gbUserInfo.Controls.Add(this.lblUsuari);
            this.gbUserInfo.Location = new System.Drawing.Point(733, 3);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbUserInfo.Size = new System.Drawing.Size(197, 45);
            this.gbUserInfo.TabIndex = 2;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.MouseHover += new System.EventHandler(this.gbUserInfo_MouseHover);
            // 
            // pbUsari
            // 
            this.pbUsari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUsari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbUsari.Location = new System.Drawing.Point(-2, 0);
            this.pbUsari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbUsari.Name = "pbUsari";
            this.pbUsari.Size = new System.Drawing.Size(54, 48);
            this.pbUsari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsari.TabIndex = 3;
            this.pbUsari.TabStop = false;
            // 
            // lblUsuari
            // 
            this.lblUsuari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuari.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuari.Location = new System.Drawing.Point(49, -3);
            this.lblUsuari.Name = "lblUsuari";
            this.lblUsuari.Size = new System.Drawing.Size(148, 48);
            this.lblUsuari.TabIndex = 0;
            this.lblUsuari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbClose.Image = global::MainForms.Properties.Resources.icon_cerrar_ventana;
            this.pbClose.Location = new System.Drawing.Point(936, 0);
            this.pbClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(54, 48);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pnlMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlMenu.Controls.Add(this.btnSpecies);
            this.pnlMenu.Controls.Add(this.btnUsers);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 48);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(197, 586);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnSpecies
            // 
            this.btnSpecies.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSpecies.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSpecies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecies.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpecies.ImageKey = "species.png";
            this.btnSpecies.ImageList = this.imlButtons;
            this.btnSpecies.Location = new System.Drawing.Point(0, 0);
            this.btnSpecies.Margin = new System.Windows.Forms.Padding(0);
            this.btnSpecies.Name = "btnSpecies";
            this.btnSpecies.Size = new System.Drawing.Size(197, 101);
            this.btnSpecies.TabIndex = 0;
            this.btnSpecies.Text = "Species";
            this.btnSpecies.UseVisualStyleBackColor = false;
            this.btnSpecies.Click += new System.EventHandler(this.btnSpecies_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.AutoSize = true;
            this.btnUsers.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.ImageKey = "users.png";
            this.btnUsers.ImageList = this.imlButtons;
            this.btnUsers.Location = new System.Drawing.Point(0, 100);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(197, 101);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // pnlPpal
            // 
            this.pnlPpal.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPpal.BackgroundImage = global::MainForms.Properties.Resources.logo;
            this.pnlPpal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlPpal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPpal.Location = new System.Drawing.Point(197, 48);
            this.pnlPpal.Name = "pnlPpal";
            this.pnlPpal.Size = new System.Drawing.Size(793, 586);
            this.pnlPpal.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 634);
            this.Controls.Add(this.pnlPpal);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Core App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlStatus.ResumeLayout(false);
            this.gbUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lblUsuari;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnSpecies;
        private System.Windows.Forms.ImageList imlButtons;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.FlowLayoutPanel pnlPpal;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.PictureBox pbUsari;
    }
}