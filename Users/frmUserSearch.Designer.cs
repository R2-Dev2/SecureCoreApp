
namespace UserCategories
{
    partial class frmUserSearch
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
            this.lblCodeSpec = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.swTxtUserName = new CustomControls.SWTextBox();
            this.swtxtCode = new CustomControls.SWTextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.swTxtLogin = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Location = new System.Drawing.Point(1071, 0);
            // 
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(217, 203);
            this.lblCodeSpec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeSpec.Name = "lblCodeSpec";
            this.lblCodeSpec.Size = new System.Drawing.Size(79, 33);
            this.lblCodeSpec.TabIndex = 25;
            this.lblCodeSpec.Text = "Code";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(139, 277);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(155, 33);
            this.lblUserName.TabIndex = 26;
            this.lblUserName.Text = "User Name";
            // 
            // swTxtUserName
            // 
            this.swTxtUserName.codiSW = null;
            this.swTxtUserName.columnName = "UserName";
            this.swTxtUserName.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtUserName.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtUserName.isForeignKey = false;
            this.swTxtUserName.Location = new System.Drawing.Point(302, 269);
            this.swTxtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTxtUserName.Name = "swTxtUserName";
            this.swTxtUserName.required = false;
            this.swTxtUserName.Size = new System.Drawing.Size(148, 41);
            this.swTxtUserName.TabIndex = 24;
            // 
            // swtxtCode
            // 
            this.swtxtCode.codiSW = null;
            this.swtxtCode.columnName = "CodeUser";
            this.swtxtCode.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCode.isForeignKey = false;
            this.swtxtCode.Location = new System.Drawing.Point(302, 194);
            this.swtxtCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtCode.Name = "swtxtCode";
            this.swtxtCode.required = false;
            this.swtxtCode.Size = new System.Drawing.Size(148, 41);
            this.swtxtCode.TabIndex = 23;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(522, 203);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(87, 33);
            this.lblLogin.TabIndex = 28;
            this.lblLogin.Text = "Login";
            // 
            // swTxtLogin
            // 
            this.swTxtLogin.codiSW = null;
            this.swTxtLogin.columnName = "Login";
            this.swTxtLogin.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtLogin.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtLogin.isForeignKey = false;
            this.swTxtLogin.Location = new System.Drawing.Point(607, 194);
            this.swTxtLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTxtLogin.Name = "swTxtLogin";
            this.swTxtLogin.required = false;
            this.swTxtLogin.Size = new System.Drawing.Size(148, 41);
            this.swTxtLogin.TabIndex = 27;
            // 
            // frmUserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 869);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.swTxtLogin);
            this.Controls.Add(this.lblCodeSpec);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.swTxtUserName);
            this.Controls.Add(this.swtxtCode);
            this.Name = "frmUserSearch";
            this.Text = "frmUserSearch";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCode, 0);
            this.Controls.SetChildIndex(this.swTxtUserName, 0);
            this.Controls.SetChildIndex(this.lblUserName, 0);
            this.Controls.SetChildIndex(this.lblCodeSpec, 0);
            this.Controls.SetChildIndex(this.swTxtLogin, 0);
            this.Controls.SetChildIndex(this.lblLogin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeSpec;
        private System.Windows.Forms.Label lblUserName;
        private CustomControls.SWTextBox swTxtUserName;
        private System.Windows.Forms.Label lblLogin;
        private CustomControls.SWTextBox swtxtCode;
        private CustomControls.SWTextBox swTxtLogin;
    }
}