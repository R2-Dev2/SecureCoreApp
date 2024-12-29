
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
            this.lblLong = new System.Windows.Forms.Label();
            this.swTxtLong = new CustomControls.SWTextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.swTxtLat = new CustomControls.SWTextBox();
            this.lblparsecs = new System.Windows.Forms.Label();
            this.swTxtparsecs = new CustomControls.SWTextBox();
            this.lblPlanetPicture = new System.Windows.Forms.Label();
            this.swTxtPlanetPicture = new CustomControls.SWTextBox();
            this.lblIPPlanet = new System.Windows.Forms.Label();
            this.swTxtIPPlanet = new CustomControls.SWTextBox();
            this.lblPortPlanet = new System.Windows.Forms.Label();
            this.swTxtPortPlanet = new CustomControls.SWTextBox();
            this.lblPortPlanet1 = new System.Windows.Forms.Label();
            this.swTxtPortPlanet1 = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Location = new System.Drawing.Point(1170, 0);
            // 
            // lblCodeSpec
            // 
            this.lblCodeSpec.AutoSize = true;
            this.lblCodeSpec.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSpec.Location = new System.Drawing.Point(90, 193);
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
            this.lblDescSpecie.Location = new System.Drawing.Point(12, 273);
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
            this.swtxtDescPlan.Location = new System.Drawing.Point(187, 267);
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
            this.swtxtCodePlan.Location = new System.Drawing.Point(187, 185);
            this.swtxtCodePlan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtCodePlan.Name = "swtxtCodePlan";
            this.swtxtCodePlan.required = false;
            this.swtxtCodePlan.Size = new System.Drawing.Size(148, 41);
            this.swtxtCodePlan.TabIndex = 23;
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.Location = new System.Drawing.Point(340, 193);
            this.lblLong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(78, 33);
            this.lblLong.TabIndex = 28;
            this.lblLong.Text = "Long";
            // 
            // swTxtLong
            // 
            this.swTxtLong.codiSW = null;
            this.swTxtLong.columnName = "long";
            this.swTxtLong.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtLong.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtLong.isForeignKey = false;
            this.swTxtLong.Location = new System.Drawing.Point(412, 188);
            this.swTxtLong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTxtLong.Name = "swTxtLong";
            this.swTxtLong.required = false;
            this.swTxtLong.Size = new System.Drawing.Size(148, 41);
            this.swTxtLong.TabIndex = 27;
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(340, 273);
            this.lblLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(55, 33);
            this.lblLat.TabIndex = 30;
            this.lblLat.Text = "Lat";
            // 
            // swTxtLat
            // 
            this.swTxtLat.codiSW = null;
            this.swTxtLat.columnName = "lat";
            this.swTxtLat.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtLat.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtLat.isForeignKey = false;
            this.swTxtLat.Location = new System.Drawing.Point(390, 265);
            this.swTxtLat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTxtLat.Name = "swTxtLat";
            this.swTxtLat.required = false;
            this.swTxtLat.Size = new System.Drawing.Size(148, 41);
            this.swTxtLat.TabIndex = 29;
            // 
            // lblparsecs
            // 
            this.lblparsecs.AutoSize = true;
            this.lblparsecs.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparsecs.Location = new System.Drawing.Point(546, 267);
            this.lblparsecs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblparsecs.Name = "lblparsecs";
            this.lblparsecs.Size = new System.Drawing.Size(113, 33);
            this.lblparsecs.TabIndex = 33;
            this.lblparsecs.Text = "Parsecs";
            // 
            // swTxtparsecs
            // 
            this.swTxtparsecs.codiSW = null;
            this.swTxtparsecs.columnName = "parsecs";
            this.swTxtparsecs.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtparsecs.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtparsecs.isForeignKey = false;
            this.swTxtparsecs.Location = new System.Drawing.Point(667, 262);
            this.swTxtparsecs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTxtparsecs.Name = "swTxtparsecs";
            this.swTxtparsecs.required = false;
            this.swTxtparsecs.Size = new System.Drawing.Size(127, 41);
            this.swTxtparsecs.TabIndex = 31;
            // 
            // lblPlanetPicture
            // 
            this.lblPlanetPicture.AutoSize = true;
            this.lblPlanetPicture.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetPicture.Location = new System.Drawing.Point(560, 193);
            this.lblPlanetPicture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanetPicture.Name = "lblPlanetPicture";
            this.lblPlanetPicture.Size = new System.Drawing.Size(198, 33);
            this.lblPlanetPicture.TabIndex = 35;
            this.lblPlanetPicture.Text = "Planet Picture";
            // 
            // swTxtPlanetPicture
            // 
            this.swTxtPlanetPicture.codiSW = null;
            this.swTxtPlanetPicture.columnName = "PlanetPicture";
            this.swTxtPlanetPicture.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtPlanetPicture.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtPlanetPicture.isForeignKey = false;
            this.swTxtPlanetPicture.Location = new System.Drawing.Point(752, 188);
            this.swTxtPlanetPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTxtPlanetPicture.Name = "swTxtPlanetPicture";
            this.swTxtPlanetPicture.required = false;
            this.swTxtPlanetPicture.Size = new System.Drawing.Size(148, 41);
            this.swTxtPlanetPicture.TabIndex = 34;
            // 
            // lblIPPlanet
            // 
            this.lblIPPlanet.AutoSize = true;
            this.lblIPPlanet.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPPlanet.Location = new System.Drawing.Point(955, 262);
            this.lblIPPlanet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPPlanet.Name = "lblIPPlanet";
            this.lblIPPlanet.Size = new System.Drawing.Size(131, 33);
            this.lblIPPlanet.TabIndex = 37;
            this.lblIPPlanet.Text = "IP Planet";
            // 
            // swTxtIPPlanet
            // 
            this.swTxtIPPlanet.codiSW = null;
            this.swTxtIPPlanet.columnName = "IPPlanet";
            this.swTxtIPPlanet.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtIPPlanet.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtIPPlanet.isForeignKey = false;
            this.swTxtIPPlanet.Location = new System.Drawing.Point(1085, 254);
            this.swTxtIPPlanet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTxtIPPlanet.Name = "swTxtIPPlanet";
            this.swTxtIPPlanet.required = false;
            this.swTxtIPPlanet.Size = new System.Drawing.Size(127, 41);
            this.swTxtIPPlanet.TabIndex = 36;
            // 
            // lblPortPlanet
            // 
            this.lblPortPlanet.AutoSize = true;
            this.lblPortPlanet.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortPlanet.Location = new System.Drawing.Point(955, 324);
            this.lblPortPlanet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortPlanet.Name = "lblPortPlanet";
            this.lblPortPlanet.Size = new System.Drawing.Size(159, 33);
            this.lblPortPlanet.TabIndex = 39;
            this.lblPortPlanet.Text = "Port Planet";
            // 
            // swTxtPortPlanet
            // 
            this.swTxtPortPlanet.codiSW = null;
            this.swTxtPortPlanet.columnName = "PortPlanet";
            this.swTxtPortPlanet.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtPortPlanet.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtPortPlanet.isForeignKey = false;
            this.swTxtPortPlanet.Location = new System.Drawing.Point(1113, 319);
            this.swTxtPortPlanet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTxtPortPlanet.Name = "swTxtPortPlanet";
            this.swTxtPortPlanet.required = false;
            this.swTxtPortPlanet.Size = new System.Drawing.Size(127, 41);
            this.swTxtPortPlanet.TabIndex = 38;
            // 
            // lblPortPlanet1
            // 
            this.lblPortPlanet1.AutoSize = true;
            this.lblPortPlanet1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortPlanet1.Location = new System.Drawing.Point(920, 198);
            this.lblPortPlanet1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortPlanet1.Name = "lblPortPlanet1";
            this.lblPortPlanet1.Size = new System.Drawing.Size(176, 33);
            this.lblPortPlanet1.TabIndex = 41;
            this.lblPortPlanet1.Text = "Port Planet1";
            // 
            // swTxtPortPlanet1
            // 
            this.swTxtPortPlanet1.codiSW = null;
            this.swTxtPortPlanet1.columnName = "PortPlanet1";
            this.swTxtPortPlanet1.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTxtPortPlanet1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTxtPortPlanet1.isForeignKey = false;
            this.swTxtPortPlanet1.Location = new System.Drawing.Point(1104, 193);
            this.swTxtPortPlanet1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTxtPortPlanet1.Name = "swTxtPortPlanet1";
            this.swTxtPortPlanet1.required = false;
            this.swTxtPortPlanet1.Size = new System.Drawing.Size(127, 41);
            this.swTxtPortPlanet1.TabIndex = 40;
            // 
            // frmPlanetsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 904);
            this.Controls.Add(this.lblPortPlanet1);
            this.Controls.Add(this.swTxtPortPlanet1);
            this.Controls.Add(this.lblPortPlanet);
            this.Controls.Add(this.swTxtPortPlanet);
            this.Controls.Add(this.lblIPPlanet);
            this.Controls.Add(this.swTxtIPPlanet);
            this.Controls.Add(this.lblPlanetPicture);
            this.Controls.Add(this.swTxtPlanetPicture);
            this.Controls.Add(this.lblparsecs);
            this.Controls.Add(this.swTxtparsecs);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.swTxtLat);
            this.Controls.Add(this.lblLong);
            this.Controls.Add(this.swTxtLong);
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
            this.Controls.SetChildIndex(this.swTxtLong, 0);
            this.Controls.SetChildIndex(this.lblLong, 0);
            this.Controls.SetChildIndex(this.swTxtLat, 0);
            this.Controls.SetChildIndex(this.lblLat, 0);
            this.Controls.SetChildIndex(this.swTxtparsecs, 0);
            this.Controls.SetChildIndex(this.lblparsecs, 0);
            this.Controls.SetChildIndex(this.swTxtPlanetPicture, 0);
            this.Controls.SetChildIndex(this.lblPlanetPicture, 0);
            this.Controls.SetChildIndex(this.swTxtIPPlanet, 0);
            this.Controls.SetChildIndex(this.lblIPPlanet, 0);
            this.Controls.SetChildIndex(this.swTxtPortPlanet, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet, 0);
            this.Controls.SetChildIndex(this.swTxtPortPlanet1, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeSpec;
        private System.Windows.Forms.Label lblDescSpecie;
        private CustomControls.SWTextBox swtxtDescPlan;
        public CustomControls.SWTextBox swtxtCodePlan;
        private System.Windows.Forms.Label lblLong;
        public CustomControls.SWTextBox swTxtLong;
        private System.Windows.Forms.Label lblLat;
        public CustomControls.SWTextBox swTxtLat;
        private System.Windows.Forms.Label lblparsecs;
        public CustomControls.SWTextBox swTxtparsecs;
        private System.Windows.Forms.Label lblPlanetPicture;
        public CustomControls.SWTextBox swTxtPlanetPicture;
        private System.Windows.Forms.Label lblIPPlanet;
        public CustomControls.SWTextBox swTxtIPPlanet;
        private System.Windows.Forms.Label lblPortPlanet;
        public CustomControls.SWTextBox swTxtPortPlanet;
        private System.Windows.Forms.Label lblPortPlanet1;
        public CustomControls.SWTextBox swTxtPortPlanet1;
    }
}