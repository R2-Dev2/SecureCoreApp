
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
            this.pnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSpecies = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pnlPpal = new System.Windows.Forms.Panel();
            this.btnSpaceShipsTypes = new System.Windows.Forms.Button();
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
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(880, 38);
            this.pnlStatus.TabIndex = 2;
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUserInfo.BackColor = System.Drawing.Color.Teal;
            this.gbUserInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbUserInfo.Controls.Add(this.pbUsari);
            this.gbUserInfo.Controls.Add(this.lblUsuari);
            this.gbUserInfo.Location = new System.Drawing.Point(652, 2);
            this.gbUserInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbUserInfo.Size = new System.Drawing.Size(175, 36);
            this.gbUserInfo.TabIndex = 2;
            this.gbUserInfo.TabStop = false;
            // 
            // pbUsari
            // 
            this.pbUsari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUsari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbUsari.Location = new System.Drawing.Point(-2, 0);
            this.pbUsari.Name = "pbUsari";
            this.pbUsari.Size = new System.Drawing.Size(48, 38);
            this.pbUsari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsari.TabIndex = 3;
            this.pbUsari.TabStop = false;
            // 
            // lblUsuari
            // 
            this.lblUsuari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuari.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuari.Location = new System.Drawing.Point(44, -2);
            this.lblUsuari.Name = "lblUsuari";
            this.lblUsuari.Size = new System.Drawing.Size(132, 38);
            this.lblUsuari.TabIndex = 0;
            this.lblUsuari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbClose.Image = global::MainForms.Properties.Resources.icon_cerrar_ventana;
            this.pbClose.Location = new System.Drawing.Point(832, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(48, 38);
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
            this.pnlMenu.Controls.Add(this.btnSpaceShipsTypes);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 38);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(175, 469);
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
            this.btnSpecies.Size = new System.Drawing.Size(175, 81);
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
            this.btnUsers.Location = new System.Drawing.Point(0, 81);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(175, 81);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // pnlPpal
            // 
            this.pnlPpal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPpal.Location = new System.Drawing.Point(175, 38);
            this.pnlPpal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPpal.Name = "pnlPpal";
            this.pnlPpal.Size = new System.Drawing.Size(705, 469);
            this.pnlPpal.TabIndex = 1;
            // 
            // btnSpaceShipsTypes
            // 
            this.btnSpaceShipsTypes.AutoSize = true;
            this.btnSpaceShipsTypes.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSpaceShipsTypes.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSpaceShipsTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpaceShipsTypes.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaceShipsTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpaceShipsTypes.ImageKey = "(ninguno)";
            this.btnSpaceShipsTypes.ImageList = this.imlButtons;
            this.btnSpaceShipsTypes.Location = new System.Drawing.Point(0, 162);
            this.btnSpaceShipsTypes.Margin = new System.Windows.Forms.Padding(0);
            this.btnSpaceShipsTypes.Name = "btnSpaceShipsTypes";
            this.btnSpaceShipsTypes.Size = new System.Drawing.Size(175, 81);
            this.btnSpaceShipsTypes.TabIndex = 2;
            this.btnSpaceShipsTypes.Text = "SpaceShip Types";
            this.btnSpaceShipsTypes.UseVisualStyleBackColor = false;
            this.btnSpaceShipsTypes.Click += new System.EventHandler(this.btnSpaceShipsTypes_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 507);
            this.Controls.Add(this.pnlPpal);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.FlowLayoutPanel pnlMenu;
        private System.Windows.Forms.Panel pnlPpal;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.PictureBox pbUsari;
        private System.Windows.Forms.Button btnSpaceShipsTypes;
    }
}