﻿
namespace Planets
{
    partial class frmPlanetsMan
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
            this.swtxtSector = new CustomControls.SWTextBox();
            this.swtxtFiliation = new CustomControls.SWTextBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblFiliation = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.swcodSector = new CustomControls.SWCodi();
            this.swcodFiliation = new CustomControls.SWCodi();
            this.swImagePlan = new CustomControls.SWTextBox();
            this.swtxtCode = new CustomControls.SWTextBox();
            this.swtxtCodiNative = new CustomControls.SWTextBox();
            this.lblNative = new System.Windows.Forms.Label();
            this.swcodNative = new CustomControls.SWCodi();
            this.lblIPPlanet = new System.Windows.Forms.Label();
            this.lblDescriptionPlanets = new System.Windows.Forms.Label();
            this.swIPPlanet = new CustomControls.SWTextBox();
            this.swDescPlan = new CustomControls.SWTextBox();
            this.lblPortPlanet = new System.Windows.Forms.Label();
            this.lbllongPlan = new System.Windows.Forms.Label();
            this.swPortPlanet = new CustomControls.SWTextBox();
            this.swtxtLong = new CustomControls.SWTextBox();
            this.lblPortPlanet1 = new System.Windows.Forms.Label();
            this.lbllat = new System.Windows.Forms.Label();
            this.swPortPlanet1 = new CustomControls.SWTextBox();
            this.swlat = new CustomControls.SWTextBox();
            this.lblParsecs = new System.Windows.Forms.Label();
            this.swParsecs = new CustomControls.SWTextBox();
            this.pbPlanet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanet)).BeginInit();
            this.SuspendLayout();
            // 
            // swtxtSector
            // 
            this.swtxtSector.codiSW = "swcodSector";
            this.swtxtSector.columnName = "idSector";
            this.swtxtSector.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtSector.Font = new System.Drawing.Font("Cambria", 1.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtSector.isForeignKey = true;
            this.swtxtSector.Location = new System.Drawing.Point(397, 273);
            this.swtxtSector.Name = "swtxtSector";
            this.swtxtSector.required = true;
            this.swtxtSector.Size = new System.Drawing.Size(100, 10);
            this.swtxtSector.TabIndex = 41;
            this.swtxtSector.TabStop = false;
            // 
            // swtxtFiliation
            // 
            this.swtxtFiliation.codiSW = "swcodFiliation";
            this.swtxtFiliation.columnName = "idFiliation";
            this.swtxtFiliation.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtFiliation.Font = new System.Drawing.Font("Cambria", 1.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtFiliation.isForeignKey = true;
            this.swtxtFiliation.Location = new System.Drawing.Point(384, 232);
            this.swtxtFiliation.Name = "swtxtFiliation";
            this.swtxtFiliation.required = true;
            this.swtxtFiliation.Size = new System.Drawing.Size(100, 10);
            this.swtxtFiliation.TabIndex = 40;
            this.swtxtFiliation.TabStop = false;
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSector.Location = new System.Drawing.Point(73, 260);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(59, 20);
            this.lblSector.TabIndex = 39;
            this.lblSector.Text = "Sector";
            // 
            // lblFiliation
            // 
            this.lblFiliation.AutoSize = true;
            this.lblFiliation.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiliation.Location = new System.Drawing.Point(59, 220);
            this.lblFiliation.Name = "lblFiliation";
            this.lblFiliation.Size = new System.Drawing.Size(73, 20);
            this.lblFiliation.TabIndex = 38;
            this.lblFiliation.Text = "Filiation";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(84, 100);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(48, 20);
            this.lblCode.TabIndex = 36;
            this.lblCode.Text = "Code";
            // 
            // swcodSector
            // 
            this.swcodSector.classeCS = "Sectors";
            this.swcodSector.codeName = "CodeSector";
            this.swcodSector.controlId = "swtxtSector";
            this.swcodSector.descName = "DescSector";
            this.swcodSector.formCS = "frmSectorsSearch";
            this.swcodSector.Location = new System.Drawing.Point(140, 256);
            this.swcodSector.Name = "swcodSector";
            this.swcodSector.nameId = "idSector";
            this.swcodSector.Size = new System.Drawing.Size(402, 29);
            this.swcodSector.TabIndex = 7;
            this.swcodSector.tableName = "Sectors";
            // 
            // swcodFiliation
            // 
            this.swcodFiliation.classeCS = "SpaceShipsTypes";
            this.swcodFiliation.codeName = "CodeFiliation";
            this.swcodFiliation.controlId = "swtxtFiliation";
            this.swcodFiliation.descName = "DescFiliations";
            this.swcodFiliation.formCS = "frmFiliationsSearch";
            this.swcodFiliation.Location = new System.Drawing.Point(140, 216);
            this.swcodFiliation.Name = "swcodFiliation";
            this.swcodFiliation.nameId = "idFiliation";
            this.swcodFiliation.Size = new System.Drawing.Size(402, 29);
            this.swcodFiliation.TabIndex = 6;
            this.swcodFiliation.tableName = "Filiations";
            // 
            // swImagePlan
            // 
            this.swImagePlan.codiSW = null;
            this.swImagePlan.columnName = "PlanetPicture";
            this.swImagePlan.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swImagePlan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swImagePlan.isForeignKey = false;
            this.swImagePlan.Location = new System.Drawing.Point(555, 216);
            this.swImagePlan.Name = "swImagePlan";
            this.swImagePlan.required = false;
            this.swImagePlan.Size = new System.Drawing.Size(175, 29);
            this.swImagePlan.TabIndex = 9;
            // 
            // swtxtCode
            // 
            this.swtxtCode.codiSW = "";
            this.swtxtCode.columnName = "CodePlanet";
            this.swtxtCode.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCode.isForeignKey = false;
            this.swtxtCode.Location = new System.Drawing.Point(140, 96);
            this.swtxtCode.Name = "swtxtCode";
            this.swtxtCode.required = true;
            this.swtxtCode.Size = new System.Drawing.Size(150, 29);
            this.swtxtCode.TabIndex = 0;
            this.swtxtCode.Tag = "CodePlanet";
            // 
            // swtxtCodiNative
            // 
            this.swtxtCodiNative.codiSW = "swcodNative";
            this.swtxtCodiNative.columnName = "idNatives";
            this.swtxtCodiNative.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtCodiNative.Font = new System.Drawing.Font("Cambria", 1.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCodiNative.isForeignKey = true;
            this.swtxtCodiNative.Location = new System.Drawing.Point(414, 308);
            this.swtxtCodiNative.Name = "swtxtCodiNative";
            this.swtxtCodiNative.required = true;
            this.swtxtCodiNative.Size = new System.Drawing.Size(77, 10);
            this.swtxtCodiNative.TabIndex = 44;
            this.swtxtCodiNative.TabStop = false;
            // 
            // lblNative
            // 
            this.lblNative.AutoSize = true;
            this.lblNative.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNative.Location = new System.Drawing.Point(73, 300);
            this.lblNative.Name = "lblNative";
            this.lblNative.Size = new System.Drawing.Size(59, 20);
            this.lblNative.TabIndex = 43;
            this.lblNative.Text = "Native";
            // 
            // swcodNative
            // 
            this.swcodNative.classeCS = "Planets";
            this.swcodNative.codeName = "CodeSpecie";
            this.swcodNative.controlId = "swtxtCodiNative";
            this.swcodNative.descName = "DescSpecie";
            this.swcodNative.formCS = "frmSpeciesSearch";
            this.swcodNative.Location = new System.Drawing.Point(140, 296);
            this.swcodNative.Name = "swcodNative";
            this.swcodNative.nameId = "idSpecie";
            this.swcodNative.Size = new System.Drawing.Size(402, 29);
            this.swcodNative.TabIndex = 8;
            this.swcodNative.tableName = "Species";
            // 
            // lblIPPlanet
            // 
            this.lblIPPlanet.AutoSize = true;
            this.lblIPPlanet.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPPlanet.Location = new System.Drawing.Point(54, 180);
            this.lblIPPlanet.Name = "lblIPPlanet";
            this.lblIPPlanet.Size = new System.Drawing.Size(78, 20);
            this.lblIPPlanet.TabIndex = 48;
            this.lblIPPlanet.Text = "IP Planet";
            // 
            // lblDescriptionPlanets
            // 
            this.lblDescriptionPlanets.AutoSize = true;
            this.lblDescriptionPlanets.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionPlanets.Location = new System.Drawing.Point(303, 100);
            this.lblDescriptionPlanets.Name = "lblDescriptionPlanets";
            this.lblDescriptionPlanets.Size = new System.Drawing.Size(100, 20);
            this.lblDescriptionPlanets.TabIndex = 47;
            this.lblDescriptionPlanets.Text = "Description";
            // 
            // swIPPlanet
            // 
            this.swIPPlanet.codiSW = null;
            this.swIPPlanet.columnName = "IPPlanet";
            this.swIPPlanet.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swIPPlanet.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swIPPlanet.isForeignKey = false;
            this.swIPPlanet.Location = new System.Drawing.Point(140, 176);
            this.swIPPlanet.Name = "swIPPlanet";
            this.swIPPlanet.required = false;
            this.swIPPlanet.Size = new System.Drawing.Size(150, 29);
            this.swIPPlanet.TabIndex = 4;
            // 
            // swDescPlan
            // 
            this.swDescPlan.codiSW = null;
            this.swDescPlan.columnName = "DescPlanet";
            this.swDescPlan.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swDescPlan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swDescPlan.isForeignKey = false;
            this.swDescPlan.Location = new System.Drawing.Point(410, 96);
            this.swDescPlan.Name = "swDescPlan";
            this.swDescPlan.required = true;
            this.swDescPlan.Size = new System.Drawing.Size(132, 29);
            this.swDescPlan.TabIndex = 1;
            // 
            // lblPortPlanet
            // 
            this.lblPortPlanet.AutoSize = true;
            this.lblPortPlanet.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortPlanet.Location = new System.Drawing.Point(569, 264);
            this.lblPortPlanet.Name = "lblPortPlanet";
            this.lblPortPlanet.Size = new System.Drawing.Size(43, 20);
            this.lblPortPlanet.TabIndex = 52;
            this.lblPortPlanet.Text = "Port";
            // 
            // lbllongPlan
            // 
            this.lbllongPlan.AutoSize = true;
            this.lbllongPlan.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllongPlan.Location = new System.Drawing.Point(316, 140);
            this.lbllongPlan.Name = "lbllongPlan";
            this.lbllongPlan.Size = new System.Drawing.Size(87, 20);
            this.lbllongPlan.TabIndex = 51;
            this.lbllongPlan.Text = "Longitude";
            // 
            // swPortPlanet
            // 
            this.swPortPlanet.codiSW = null;
            this.swPortPlanet.columnName = "PortPlanet";
            this.swPortPlanet.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swPortPlanet.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swPortPlanet.isForeignKey = false;
            this.swPortPlanet.Location = new System.Drawing.Point(618, 256);
            this.swPortPlanet.Name = "swPortPlanet";
            this.swPortPlanet.required = false;
            this.swPortPlanet.Size = new System.Drawing.Size(112, 29);
            this.swPortPlanet.TabIndex = 10;
            // 
            // swtxtLong
            // 
            this.swtxtLong.codiSW = null;
            this.swtxtLong.columnName = "long";
            this.swtxtLong.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtLong.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtLong.isForeignKey = false;
            this.swtxtLong.Location = new System.Drawing.Point(410, 136);
            this.swtxtLong.Name = "swtxtLong";
            this.swtxtLong.required = true;
            this.swtxtLong.Size = new System.Drawing.Size(132, 29);
            this.swtxtLong.TabIndex = 3;
            // 
            // lblPortPlanet1
            // 
            this.lblPortPlanet1.AutoSize = true;
            this.lblPortPlanet1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortPlanet1.Location = new System.Drawing.Point(555, 300);
            this.lblPortPlanet1.Name = "lblPortPlanet1";
            this.lblPortPlanet1.Size = new System.Drawing.Size(57, 20);
            this.lblPortPlanet1.TabIndex = 56;
            this.lblPortPlanet1.Text = "Port 2";
            // 
            // lbllat
            // 
            this.lbllat.AutoSize = true;
            this.lbllat.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllat.Location = new System.Drawing.Point(59, 140);
            this.lbllat.Name = "lbllat";
            this.lbllat.Size = new System.Drawing.Size(73, 20);
            this.lbllat.TabIndex = 55;
            this.lbllat.Text = "Latitude";
            // 
            // swPortPlanet1
            // 
            this.swPortPlanet1.codiSW = null;
            this.swPortPlanet1.columnName = "PortPlanet1";
            this.swPortPlanet1.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swPortPlanet1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swPortPlanet1.isForeignKey = false;
            this.swPortPlanet1.Location = new System.Drawing.Point(618, 296);
            this.swPortPlanet1.Name = "swPortPlanet1";
            this.swPortPlanet1.required = false;
            this.swPortPlanet1.Size = new System.Drawing.Size(112, 29);
            this.swPortPlanet1.TabIndex = 11;
            // 
            // swlat
            // 
            this.swlat.codiSW = null;
            this.swlat.columnName = "lat";
            this.swlat.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swlat.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swlat.isForeignKey = false;
            this.swlat.Location = new System.Drawing.Point(140, 136);
            this.swlat.Name = "swlat";
            this.swlat.required = true;
            this.swlat.Size = new System.Drawing.Size(150, 29);
            this.swlat.TabIndex = 2;
            // 
            // lblParsecs
            // 
            this.lblParsecs.AutoSize = true;
            this.lblParsecs.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParsecs.Location = new System.Drawing.Point(334, 186);
            this.lblParsecs.Name = "lblParsecs";
            this.lblParsecs.Size = new System.Drawing.Size(69, 20);
            this.lblParsecs.TabIndex = 59;
            this.lblParsecs.Text = "Parsecs";
            // 
            // swParsecs
            // 
            this.swParsecs.codiSW = null;
            this.swParsecs.columnName = "parsecs";
            this.swParsecs.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swParsecs.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swParsecs.isForeignKey = false;
            this.swParsecs.Location = new System.Drawing.Point(410, 182);
            this.swParsecs.Name = "swParsecs";
            this.swParsecs.required = true;
            this.swParsecs.Size = new System.Drawing.Size(132, 29);
            this.swParsecs.TabIndex = 5;
            // 
            // pbPlanet
            // 
            this.pbPlanet.Location = new System.Drawing.Point(555, 96);
            this.pbPlanet.Name = "pbPlanet";
            this.pbPlanet.Size = new System.Drawing.Size(175, 112);
            this.pbPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlanet.TabIndex = 60;
            this.pbPlanet.TabStop = false;
            // 
            // frmPlanetsMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 706);
            this.Controls.Add(this.pbPlanet);
            this.Controls.Add(this.lblParsecs);
            this.Controls.Add(this.swParsecs);
            this.Controls.Add(this.lblPortPlanet1);
            this.Controls.Add(this.lbllat);
            this.Controls.Add(this.swPortPlanet1);
            this.Controls.Add(this.swlat);
            this.Controls.Add(this.lblPortPlanet);
            this.Controls.Add(this.lbllongPlan);
            this.Controls.Add(this.swPortPlanet);
            this.Controls.Add(this.swtxtLong);
            this.Controls.Add(this.lblIPPlanet);
            this.Controls.Add(this.lblDescriptionPlanets);
            this.Controls.Add(this.swIPPlanet);
            this.Controls.Add(this.swDescPlan);
            this.Controls.Add(this.lblNative);
            this.Controls.Add(this.swcodNative);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.lblFiliation);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.swcodSector);
            this.Controls.Add(this.swcodFiliation);
            this.Controls.Add(this.swImagePlan);
            this.Controls.Add(this.swtxtCode);
            this.Controls.Add(this.swtxtCodiNative);
            this.Controls.Add(this.swtxtSector);
            this.Controls.Add(this.swtxtFiliation);
            this.Name = "frmPlanetsMan";
            this.Text = "frmPlanetsMant";
            this.Controls.SetChildIndex(this.swtxtFiliation, 0);
            this.Controls.SetChildIndex(this.swtxtSector, 0);
            this.Controls.SetChildIndex(this.swtxtCodiNative, 0);
            this.Controls.SetChildIndex(this.pbClose, 0);
            this.Controls.SetChildIndex(this.swtxtCode, 0);
            this.Controls.SetChildIndex(this.swImagePlan, 0);
            this.Controls.SetChildIndex(this.swcodFiliation, 0);
            this.Controls.SetChildIndex(this.swcodSector, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.lblFiliation, 0);
            this.Controls.SetChildIndex(this.lblSector, 0);
            this.Controls.SetChildIndex(this.swcodNative, 0);
            this.Controls.SetChildIndex(this.lblNative, 0);
            this.Controls.SetChildIndex(this.swDescPlan, 0);
            this.Controls.SetChildIndex(this.swIPPlanet, 0);
            this.Controls.SetChildIndex(this.lblDescriptionPlanets, 0);
            this.Controls.SetChildIndex(this.lblIPPlanet, 0);
            this.Controls.SetChildIndex(this.swtxtLong, 0);
            this.Controls.SetChildIndex(this.swPortPlanet, 0);
            this.Controls.SetChildIndex(this.lbllongPlan, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet, 0);
            this.Controls.SetChildIndex(this.swlat, 0);
            this.Controls.SetChildIndex(this.swPortPlanet1, 0);
            this.Controls.SetChildIndex(this.lbllat, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet1, 0);
            this.Controls.SetChildIndex(this.swParsecs, 0);
            this.Controls.SetChildIndex(this.lblParsecs, 0);
            this.Controls.SetChildIndex(this.pbPlanet, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox swtxtSector;
        private CustomControls.SWTextBox swtxtFiliation;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblFiliation;
        private System.Windows.Forms.Label lblCode;
        private CustomControls.SWCodi swcodSector;
        private CustomControls.SWCodi swcodFiliation;
        private CustomControls.SWTextBox swImagePlan;
        private CustomControls.SWTextBox swtxtCode;
        private CustomControls.SWTextBox swtxtCodiNative;
        private System.Windows.Forms.Label lblNative;
        private CustomControls.SWCodi swcodNative;
        private System.Windows.Forms.Label lblIPPlanet;
        private System.Windows.Forms.Label lblDescriptionPlanets;
        private CustomControls.SWTextBox swIPPlanet;
        private CustomControls.SWTextBox swDescPlan;
        private System.Windows.Forms.Label lblPortPlanet;
        private System.Windows.Forms.Label lbllongPlan;
        private CustomControls.SWTextBox swPortPlanet;
        private CustomControls.SWTextBox swtxtLong;
        private System.Windows.Forms.Label lblPortPlanet1;
        private System.Windows.Forms.Label lbllat;
        private CustomControls.SWTextBox swPortPlanet1;
        private CustomControls.SWTextBox swlat;
        private System.Windows.Forms.Label lblParsecs;
        private CustomControls.SWTextBox swParsecs;
        private System.Windows.Forms.PictureBox pbPlanet;
    }
}