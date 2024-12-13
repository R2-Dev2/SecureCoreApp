
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
            this.swTextBox1 = new CustomControls.SWTextBox();
            this.swTextBox2 = new CustomControls.SWTextBox();
            this.swTextBox3 = new CustomControls.SWTextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblAccLev = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // swTextBox1
            // 
            this.swTextBox1.columnName = null;
            this.swTextBox1.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox1.isForeignKey = false;
            this.swTextBox1.Location = new System.Drawing.Point(210, 187);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.opcionalDada = false;
            this.swTextBox1.required = false;
            this.swTextBox1.Size = new System.Drawing.Size(268, 41);
            this.swTextBox1.TabIndex = 22;
            this.swTextBox1.Tag = "CodeCategory";
            // 
            // swTextBox2
            // 
            this.swTextBox2.columnName = null;
            this.swTextBox2.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox2.isForeignKey = false;
            this.swTextBox2.Location = new System.Drawing.Point(210, 299);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.opcionalDada = false;
            this.swTextBox2.required = false;
            this.swTextBox2.Size = new System.Drawing.Size(268, 41);
            this.swTextBox2.TabIndex = 23;
            this.swTextBox2.Tag = "DescCategory";
            // 
            // swTextBox3
            // 
            this.swTextBox3.columnName = null;
            this.swTextBox3.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swTextBox3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox3.isForeignKey = false;
            this.swTextBox3.Location = new System.Drawing.Point(592, 187);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.opcionalDada = false;
            this.swTextBox3.required = false;
            this.swTextBox3.Size = new System.Drawing.Size(268, 41);
            this.swTextBox3.TabIndex = 24;
            this.swTextBox3.Tag = "AccessLevel";
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
            this.Controls.Add(this.swTextBox3);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
            this.Name = "frmUserCategory";
            this.Text = "frmUserCategory";
            this.Load += new System.EventHandler(this.frmUserCategory_Load);
            this.Controls.SetChildIndex(this.swTextBox1, 0);
            this.Controls.SetChildIndex(this.swTextBox2, 0);
            this.Controls.SetChildIndex(this.swTextBox3, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.lblDesc, 0);
            this.Controls.SetChildIndex(this.lblAccLev, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox swTextBox1;
        private CustomControls.SWTextBox swTextBox2;
        private CustomControls.SWTextBox swTextBox3;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblAccLev;
    }
}