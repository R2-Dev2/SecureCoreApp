
namespace Users
{
    partial class frmUserProfile
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPicture = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.swtxtUsername = new CustomControls.SWTextBox();
            this.swtxtName = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(56, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(299, 121);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicture.Location = new System.Drawing.Point(56, 171);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(122, 20);
            this.lblPicture.TabIndex = 4;
            this.lblPicture.Text = "Profile Picture";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(467, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImage.Location = new System.Drawing.Point(229, 307);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(43, 28);
            this.btnSelectImage.TabIndex = 2;
            this.btnSelectImage.Text = "...";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(58, 39);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(389, 33);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Edit your profile information";
            // 
            // lblSave
            // 
            this.lblSave.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.Location = new System.Drawing.Point(271, 338);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(284, 20);
            this.lblSave.TabIndex = 10;
            this.lblSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbClose
            // 
            this.pbClose.Image = global::Users.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(576, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(31, 32);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 8;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbProfile
            // 
            this.pbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProfile.Image = global::Users.Properties.Resources.login;
            this.pbProfile.InitialImage = global::Users.Properties.Resources.login;
            this.pbProfile.Location = new System.Drawing.Point(60, 203);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(153, 132);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 5;
            this.pbProfile.TabStop = false;
            // 
            // swtxtUsername
            // 
            this.swtxtUsername.codiSW = null;
            this.swtxtUsername.columnName = "Login";
            this.swtxtUsername.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtUsername.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtUsername.isForeignKey = false;
            this.swtxtUsername.Location = new System.Drawing.Point(393, 117);
            this.swtxtUsername.Name = "swtxtUsername";
            this.swtxtUsername.required = true;
            this.swtxtUsername.Size = new System.Drawing.Size(162, 29);
            this.swtxtUsername.TabIndex = 1;
            this.swtxtUsername.TabStop = false;
            // 
            // swtxtName
            // 
            this.swtxtName.codiSW = null;
            this.swtxtName.columnName = "userName";
            this.swtxtName.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtName.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtName.isForeignKey = false;
            this.swtxtName.Location = new System.Drawing.Point(116, 117);
            this.swtxtName.Name = "swtxtName";
            this.swtxtName.required = true;
            this.swtxtName.Size = new System.Drawing.Size(139, 29);
            this.swtxtName.TabIndex = 0;
            this.swtxtName.TabStop = false;
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(606, 376);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.swtxtUsername);
            this.Controls.Add(this.swtxtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserProfile";
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox swtxtName;
        private CustomControls.SWTextBox swtxtUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSave;
    }
}