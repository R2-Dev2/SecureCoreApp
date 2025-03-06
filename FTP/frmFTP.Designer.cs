
namespace FTP
{
    partial class frmFTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFTP));
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lsbInfo = new System.Windows.Forms.ListBox();
            this.btnChangeDirectory = new System.Windows.Forms.Button();
            this.btnUpdateCredentials = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtDownloadDir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(789, 0);
            this.pbClose.Margin = new System.Windows.Forms.Padding(0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 23);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 21;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(74, 97);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(179, 39);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download files";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(67, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 38);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "FTP";
            // 
            // lsbInfo
            // 
            this.lsbInfo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbInfo.FormattingEnabled = true;
            this.lsbInfo.HorizontalScrollbar = true;
            this.lsbInfo.ItemHeight = 20;
            this.lsbInfo.Location = new System.Drawing.Point(74, 216);
            this.lsbInfo.Name = "lsbInfo";
            this.lsbInfo.Size = new System.Drawing.Size(649, 524);
            this.lsbInfo.TabIndex = 101;
            // 
            // btnChangeDirectory
            // 
            this.btnChangeDirectory.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeDirectory.Location = new System.Drawing.Point(537, 103);
            this.btnChangeDirectory.Name = "btnChangeDirectory";
            this.btnChangeDirectory.Size = new System.Drawing.Size(51, 27);
            this.btnChangeDirectory.TabIndex = 1;
            this.btnChangeDirectory.Text = "...";
            this.btnChangeDirectory.UseVisualStyleBackColor = true;
            this.btnChangeDirectory.Click += new System.EventHandler(this.btnChangeDirectory_Click);
            // 
            // btnUpdateCredentials
            // 
            this.btnUpdateCredentials.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCredentials.Location = new System.Drawing.Point(74, 155);
            this.btnUpdateCredentials.Name = "btnUpdateCredentials";
            this.btnUpdateCredentials.Size = new System.Drawing.Size(179, 39);
            this.btnUpdateCredentials.TabIndex = 2;
            this.btnUpdateCredentials.Text = "Update credentials";
            this.btnUpdateCredentials.UseVisualStyleBackColor = true;
            this.btnUpdateCredentials.Click += new System.EventHandler(this.btnUpdateCredentials_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(608, 97);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(115, 39);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtDownloadDir
            // 
            this.txtDownloadDir.Enabled = false;
            this.txtDownloadDir.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownloadDir.Location = new System.Drawing.Point(259, 103);
            this.txtDownloadDir.Name = "txtDownloadDir";
            this.txtDownloadDir.Size = new System.Drawing.Size(272, 27);
            this.txtDownloadDir.TabIndex = 102;
            // 
            // frmFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(814, 751);
            this.Controls.Add(this.txtDownloadDir);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnUpdateCredentials);
            this.Controls.Add(this.btnChangeDirectory);
            this.Controls.Add(this.lsbInfo);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFTP";
            this.Text = "frmFTP";
            this.Load += new System.EventHandler(this.frmFTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lsbInfo;
        private System.Windows.Forms.Button btnChangeDirectory;
        private System.Windows.Forms.Button btnUpdateCredentials;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtDownloadDir;
    }
}