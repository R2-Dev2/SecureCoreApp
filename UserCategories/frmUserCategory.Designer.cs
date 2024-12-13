
namespace UserCategories
{
    partial class frmUserCategory
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
            this.tbCode = new CustomControls.SWTextBox();
            this.tbDesc = new CustomControls.SWTextBox();
            this.tbAccesLev = new CustomControls.SWTextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblAccLev = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCode
            // 
            this.tbCode.columnName = null;
            this.tbCode.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.tbCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.isForeignKey = false;
            this.tbCode.Location = new System.Drawing.Point(210, 187);
            this.tbCode.Name = "tbCode";
            this.tbCode.opcionalDada = false;
            this.tbCode.required = false;
            this.tbCode.Size = new System.Drawing.Size(268, 41);
            this.tbCode.TabIndex = 22;
            this.tbCode.Tag = "CodeCategory";
            // 
            // tbDesc
            // 
            this.tbDesc.columnName = null;
            this.tbDesc.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.tbDesc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc.isForeignKey = false;
            this.tbDesc.Location = new System.Drawing.Point(210, 299);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.opcionalDada = false;
            this.tbDesc.required = false;
            this.tbDesc.Size = new System.Drawing.Size(268, 41);
            this.tbDesc.TabIndex = 23;
            this.tbDesc.Tag = "DescCategory";
            // 
            // tbAccesLev
            // 
            this.tbAccesLev.columnName = null;
            this.tbAccesLev.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.tbAccesLev.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccesLev.isForeignKey = false;
            this.tbAccesLev.Location = new System.Drawing.Point(592, 187);
            this.tbAccesLev.Name = "tbAccesLev";
            this.tbAccesLev.opcionalDada = false;
            this.tbAccesLev.required = false;
            this.tbAccesLev.Size = new System.Drawing.Size(268, 41);
            this.tbAccesLev.TabIndex = 24;
            this.tbAccesLev.Tag = "AccessLevel";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(128, 139);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(63, 25);
            this.lblCode.TabIndex = 25;
            this.lblCode.Text = "Code";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(128, 259);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(120, 25);
            this.lblDesc.TabIndex = 26;
            this.lblDesc.Text = "Description";
            // 
            // lblAccLev
            // 
            this.lblAccLev.AutoSize = true;
            this.lblAccLev.Location = new System.Drawing.Point(518, 139);
            this.lblAccLev.Name = "lblAccLev";
            this.lblAccLev.Size = new System.Drawing.Size(140, 25);
            this.lblAccLev.TabIndex = 27;
            this.lblAccLev.Text = "Access Level";
            // 
            // frmUserCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 956);
            this.Controls.Add(this.lblAccLev);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.tbAccesLev);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbCode);
            this.Name = "frmUserCategory";
            this.Text = "frmUserCategory";
            this.Load += new System.EventHandler(this.frmUserCategory_Load);
            this.Controls.SetChildIndex(this.tbCode, 0);
            this.Controls.SetChildIndex(this.tbDesc, 0);
            this.Controls.SetChildIndex(this.tbAccesLev, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.lblDesc, 0);
            this.Controls.SetChildIndex(this.lblAccLev, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox tbCode;
        private CustomControls.SWTextBox tbDesc;
        private CustomControls.SWTextBox tbAccesLev;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblAccLev;
    }
}