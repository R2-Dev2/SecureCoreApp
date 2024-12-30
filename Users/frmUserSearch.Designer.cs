
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
            this.pbClose.Location = new System.Drawing.Point(734, 0);
            // 
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(85, 126);
            this.lblCodeSpec.Name = "lblCodeSpec";
            this.lblCodeSpec.Size = new System.Drawing.Size(48, 20);
            this.lblCodeSpec.TabIndex = 25;
            this.lblCodeSpec.Text = "Code";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(39, 177);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(94, 20);
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
            this.swTxtUserName.Location = new System.Drawing.Point(164, 173);
            this.swTxtUserName.Name = "swTxtUserName";
            this.swTxtUserName.required = false;
            this.swTxtUserName.Size = new System.Drawing.Size(148, 29);
            this.swTxtUserName.TabIndex = 24;
            // 
            // swtxtCode
            // 
            this.swtxtCode.codiSW = null;
            this.swtxtCode.columnName = "CodeUser";
            this.swtxtCode.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCode.isForeignKey = false;
            this.swtxtCode.Location = new System.Drawing.Point(164, 122);
            this.swtxtCode.Name = "swtxtCode";
            this.swtxtCode.required = false;
            this.swtxtCode.Size = new System.Drawing.Size(148, 29);
            this.swtxtCode.TabIndex = 23;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(81, 228);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(52, 20);
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
            this.swTxtLogin.Location = new System.Drawing.Point(164, 225);
            this.swTxtLogin.Name = "swTxtLogin";
            this.swTxtLogin.required = false;
            this.swTxtLogin.Size = new System.Drawing.Size(148, 29);
            this.swTxtLogin.TabIndex = 27;
            // 
            // frmUserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 633);
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