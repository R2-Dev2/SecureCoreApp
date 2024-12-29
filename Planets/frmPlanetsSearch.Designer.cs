
namespace Planets
{
    partial class frmPlanetsSearch
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
            this.lblDescSpecie = new System.Windows.Forms.Label();
            this.swtxtDescPlan = new CustomControls.SWTextBox();
            this.swtxtCodePlan = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Location = new System.Drawing.Point(983, 0);
            // 
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(221, 207);
            this.lblCodeSpec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeSpec.Name = "lblCodeSpec";
            this.lblCodeSpec.Size = new System.Drawing.Size(79, 33);
            this.lblCodeSpec.TabIndex = 25;
            this.lblCodeSpec.Text = "Code";
            // 
            // lblDescSpecie
            // 
            this.lblDescSpecie.AutoSize = true;
            this.lblDescSpecie.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSpecie.Location = new System.Drawing.Point(143, 287);
            this.lblDescSpecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescSpecie.Name = "lblDescSpecie";
            this.lblDescSpecie.Size = new System.Drawing.Size(167, 33);
            this.lblDescSpecie.TabIndex = 26;
            this.lblDescSpecie.Text = "Description";
            // 
            // swtxtDescPlan
            // 
            this.swtxtDescPlan.codiSW = null;
            this.swtxtDescPlan.columnName = "DescPlanet";
            this.swtxtDescPlan.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDescPlan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDescPlan.isForeignKey = false;
            this.swtxtDescPlan.Location = new System.Drawing.Point(306, 279);
            this.swtxtDescPlan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtDescPlan.Name = "swtxtDescPlan";
            this.swtxtDescPlan.required = false;
            this.swtxtDescPlan.Size = new System.Drawing.Size(148, 41);
            this.swtxtDescPlan.TabIndex = 24;
            // 
            // swtxtCodePlan
            // 
            this.swtxtCodePlan.codiSW = null;
            this.swtxtCodePlan.columnName = "CodePlanet";
            this.swtxtCodePlan.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCodePlan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCodePlan.isForeignKey = false;
            this.swtxtCodePlan.Location = new System.Drawing.Point(306, 198);
            this.swtxtCodePlan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtCodePlan.Name = "swtxtCodePlan";
            this.swtxtCodePlan.required = false;
            this.swtxtCodePlan.Size = new System.Drawing.Size(148, 41);
            this.swtxtCodePlan.TabIndex = 23;
            // 
            // frmPlanetsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 904);
            this.Controls.Add(this.lblCodeSpec);
            this.Controls.Add(this.lblDescSpecie);
            this.Controls.Add(this.swtxtDescPlan);
            this.Controls.Add(this.swtxtCodePlan);
            this.Name = "frmPlanetsSearch";
            this.Text = "frmPlanetsSearch";
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCodePlan, 0);
            this.Controls.SetChildIndex(this.swtxtDescPlan, 0);
            this.Controls.SetChildIndex(this.lblDescSpecie, 0);
            this.Controls.SetChildIndex(this.lblCodeSpec, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeSpec;
        private System.Windows.Forms.Label lblDescSpecie;
        private CustomControls.SWTextBox swtxtDescPlan;
        public CustomControls.SWTextBox swtxtCodePlan;
    }
}