
namespace Planets
{
    partial class frmPlanetsMant
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
            this.lblImagePlan = new System.Windows.Forms.Label();
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
            this.swTextBox5 = new CustomControls.SWTextBox();
            this.lblPortPlanet1 = new System.Windows.Forms.Label();
            this.lbllat = new System.Windows.Forms.Label();
            this.swPortPlanet1 = new CustomControls.SWTextBox();
            this.swlat = new CustomControls.SWTextBox();
            this.lblParsecs = new System.Windows.Forms.Label();
            this.swParsecs = new CustomControls.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Location = new System.Drawing.Point(1883, 0);
            // 
            // swtxtSector
            // 
            this.swtxtSector.codiSW = "swcodSector";
            this.swtxtSector.columnName = "idSector";
            this.swtxtSector.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtSector.Font = new System.Drawing.Font("Cambria", 1.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtSector.isForeignKey = true;
            this.swtxtSector.Location = new System.Drawing.Point(645, 265);
            this.swtxtSector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtSector.Name = "swtxtSector";
            this.swtxtSector.required = true;
            this.swtxtSector.Size = new System.Drawing.Size(148, 11);
            this.swtxtSector.TabIndex = 41;
            // 
            // swtxtFiliation
            // 
            this.swtxtFiliation.codiSW = "swcodFiliation";
            this.swtxtFiliation.columnName = "idFiliation";
            this.swtxtFiliation.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtFiliation.Font = new System.Drawing.Font("Cambria", 1.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtFiliation.isForeignKey = true;
            this.swtxtFiliation.Location = new System.Drawing.Point(626, 201);
            this.swtxtFiliation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtFiliation.Name = "swtxtFiliation";
            this.swtxtFiliation.required = true;
            this.swtxtFiliation.Size = new System.Drawing.Size(148, 11);
            this.swtxtFiliation.TabIndex = 40;
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(108, 251);
            this.lblSector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(74, 25);
            this.lblSector.TabIndex = 39;
            this.lblSector.Text = "Sector";
            // 
            // lblFiliation
            // 
            this.lblFiliation.AutoSize = true;
            this.lblFiliation.Location = new System.Drawing.Point(108, 187);
            this.lblFiliation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiliation.Name = "lblFiliation";
            this.lblFiliation.Size = new System.Drawing.Size(87, 25);
            this.lblFiliation.TabIndex = 38;
            this.lblFiliation.Text = "Filiation";
            // 
            // lblImagePlan
            // 
            this.lblImagePlan.AutoSize = true;
            this.lblImagePlan.Location = new System.Drawing.Point(1381, 420);
            this.lblImagePlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagePlan.Name = "lblImagePlan";
            this.lblImagePlan.Size = new System.Drawing.Size(70, 25);
            this.lblImagePlan.TabIndex = 37;
            this.lblImagePlan.Text = "Image";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(1053, 412);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(63, 25);
            this.lblCode.TabIndex = 36;
            this.lblCode.Text = "Code";
            // 
            // swcodSector
            // 
            this.swcodSector.classeCS = "Sectors";
            this.swcodSector.codeName = "CodeSector";
            this.swcodSector.controlId = "swtxtSector";
            this.swcodSector.descName = "DescSector";
            this.swcodSector.formCS = "frmSectorSearch";
            this.swcodSector.Location = new System.Drawing.Point(233, 251);
            this.swcodSector.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.swcodSector.Name = "swcodSector";
            this.swcodSector.nameId = "idSector";
            this.swcodSector.Size = new System.Drawing.Size(591, 42);
            this.swcodSector.TabIndex = 35;
            this.swcodSector.tableName = "Sectors";
            // 
            // swcodFiliation
            // 
            this.swcodFiliation.classeCS = "SpaceShipsTypes";
            this.swcodFiliation.codeName = "CodeFiliation";
            this.swcodFiliation.controlId = "swtxtFiliation";
            this.swcodFiliation.descName = "DescFiliations";
            this.swcodFiliation.formCS = "frmFiliationsSearch";
            this.swcodFiliation.Location = new System.Drawing.Point(233, 187);
            this.swcodFiliation.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.swcodFiliation.Name = "swcodFiliation";
            this.swcodFiliation.nameId = "idFiliation";
            this.swcodFiliation.Size = new System.Drawing.Size(591, 42);
            this.swcodFiliation.TabIndex = 34;
            this.swcodFiliation.tableName = "Filiations";
            // 
            // swImagePlan
            // 
            this.swImagePlan.codiSW = null;
            this.swImagePlan.columnName = "PlanetPicture";
            this.swImagePlan.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swImagePlan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swImagePlan.isForeignKey = false;
            this.swImagePlan.Location = new System.Drawing.Point(1529, 409);
            this.swImagePlan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swImagePlan.Name = "swImagePlan";
            this.swImagePlan.required = true;
            this.swImagePlan.Size = new System.Drawing.Size(296, 41);
            this.swImagePlan.TabIndex = 33;
            // 
            // swtxtCode
            // 
            this.swtxtCode.codiSW = "";
            this.swtxtCode.columnName = "CodePlanet";
            this.swtxtCode.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCode.isForeignKey = false;
            this.swtxtCode.Location = new System.Drawing.Point(1178, 409);
            this.swtxtCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtCode.Name = "swtxtCode";
            this.swtxtCode.required = true;
            this.swtxtCode.Size = new System.Drawing.Size(148, 41);
            this.swtxtCode.TabIndex = 32;
            this.swtxtCode.Tag = "CodePlanet";
            // 
            // swtxtCodiNative
            // 
            this.swtxtCodiNative.codiSW = "swcodNative";
            this.swtxtCodiNative.columnName = "idNatives";
            this.swtxtCodiNative.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtCodiNative.Font = new System.Drawing.Font("Cambria", 1.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtCodiNative.isForeignKey = true;
            this.swtxtCodiNative.Location = new System.Drawing.Point(680, 320);
            this.swtxtCodiNative.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swtxtCodiNative.Name = "swtxtCodiNative";
            this.swtxtCodiNative.required = true;
            this.swtxtCodiNative.Size = new System.Drawing.Size(113, 11);
            this.swtxtCodiNative.TabIndex = 44;
            // 
            // lblNative
            // 
            this.lblNative.AutoSize = true;
            this.lblNative.Location = new System.Drawing.Point(108, 306);
            this.lblNative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNative.Name = "lblNative";
            this.lblNative.Size = new System.Drawing.Size(73, 25);
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
            this.swcodNative.Location = new System.Drawing.Point(233, 306);
            this.swcodNative.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.swcodNative.Name = "swcodNative";
            this.swcodNative.nameId = "idSpecie";
            this.swcodNative.Size = new System.Drawing.Size(591, 42);
            this.swcodNative.TabIndex = 42;
            this.swcodNative.tableName = "Species";
            // 
            // lblIPPlanet
            // 
            this.lblIPPlanet.AutoSize = true;
            this.lblIPPlanet.Location = new System.Drawing.Point(1381, 496);
            this.lblIPPlanet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPPlanet.Name = "lblIPPlanet";
            this.lblIPPlanet.Size = new System.Drawing.Size(98, 25);
            this.lblIPPlanet.TabIndex = 48;
            this.lblIPPlanet.Text = "IP Planet";
            // 
            // lblDescriptionPlanets
            // 
            this.lblDescriptionPlanets.AutoSize = true;
            this.lblDescriptionPlanets.Location = new System.Drawing.Point(1053, 488);
            this.lblDescriptionPlanets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptionPlanets.Name = "lblDescriptionPlanets";
            this.lblDescriptionPlanets.Size = new System.Drawing.Size(120, 25);
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
            this.swIPPlanet.Location = new System.Drawing.Point(1529, 485);
            this.swIPPlanet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swIPPlanet.Name = "swIPPlanet";
            this.swIPPlanet.required = true;
            this.swIPPlanet.Size = new System.Drawing.Size(296, 41);
            this.swIPPlanet.TabIndex = 46;
            // 
            // swDescPlan
            // 
            this.swDescPlan.codiSW = null;
            this.swDescPlan.columnName = "DescPlanet";
            this.swDescPlan.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swDescPlan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swDescPlan.isForeignKey = false;
            this.swDescPlan.Location = new System.Drawing.Point(1178, 485);
            this.swDescPlan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swDescPlan.Name = "swDescPlan";
            this.swDescPlan.required = true;
            this.swDescPlan.Size = new System.Drawing.Size(148, 41);
            this.swDescPlan.TabIndex = 45;
            // 
            // lblPortPlanet
            // 
            this.lblPortPlanet.AutoSize = true;
            this.lblPortPlanet.Location = new System.Drawing.Point(1381, 582);
            this.lblPortPlanet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortPlanet.Name = "lblPortPlanet";
            this.lblPortPlanet.Size = new System.Drawing.Size(118, 25);
            this.lblPortPlanet.TabIndex = 52;
            this.lblPortPlanet.Text = "Port Planet";
            // 
            // lbllongPlan
            // 
            this.lbllongPlan.AutoSize = true;
            this.lbllongPlan.Location = new System.Drawing.Point(1053, 574);
            this.lbllongPlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllongPlan.Name = "lbllongPlan";
            this.lbllongPlan.Size = new System.Drawing.Size(60, 25);
            this.lbllongPlan.TabIndex = 51;
            this.lbllongPlan.Text = "Long";
            // 
            // swPortPlanet
            // 
            this.swPortPlanet.codiSW = null;
            this.swPortPlanet.columnName = "PortPlanet";
            this.swPortPlanet.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swPortPlanet.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swPortPlanet.isForeignKey = false;
            this.swPortPlanet.Location = new System.Drawing.Point(1529, 571);
            this.swPortPlanet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swPortPlanet.Name = "swPortPlanet";
            this.swPortPlanet.required = true;
            this.swPortPlanet.Size = new System.Drawing.Size(296, 41);
            this.swPortPlanet.TabIndex = 50;
            // 
            // swTextBox5
            // 
            this.swTextBox5.codiSW = null;
            this.swTextBox5.columnName = "long";
            this.swTextBox5.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swTextBox5.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox5.isForeignKey = false;
            this.swTextBox5.Location = new System.Drawing.Point(1178, 571);
            this.swTextBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox5.Name = "swTextBox5";
            this.swTextBox5.required = true;
            this.swTextBox5.Size = new System.Drawing.Size(148, 41);
            this.swTextBox5.TabIndex = 49;
            // 
            // lblPortPlanet1
            // 
            this.lblPortPlanet1.AutoSize = true;
            this.lblPortPlanet1.Location = new System.Drawing.Point(1381, 658);
            this.lblPortPlanet1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortPlanet1.Name = "lblPortPlanet1";
            this.lblPortPlanet1.Size = new System.Drawing.Size(124, 25);
            this.lblPortPlanet1.TabIndex = 56;
            this.lblPortPlanet1.Text = "PortPlanet1";
            // 
            // lbllat
            // 
            this.lbllat.AutoSize = true;
            this.lbllat.Location = new System.Drawing.Point(1053, 650);
            this.lbllat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllat.Name = "lbllat";
            this.lbllat.Size = new System.Drawing.Size(42, 25);
            this.lbllat.TabIndex = 55;
            this.lbllat.Text = "Lat";
            // 
            // swPortPlanet1
            // 
            this.swPortPlanet1.codiSW = null;
            this.swPortPlanet1.columnName = "PortPlanet1";
            this.swPortPlanet1.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swPortPlanet1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swPortPlanet1.isForeignKey = false;
            this.swPortPlanet1.Location = new System.Drawing.Point(1529, 647);
            this.swPortPlanet1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swPortPlanet1.Name = "swPortPlanet1";
            this.swPortPlanet1.required = true;
            this.swPortPlanet1.Size = new System.Drawing.Size(296, 41);
            this.swPortPlanet1.TabIndex = 54;
            // 
            // swlat
            // 
            this.swlat.codiSW = null;
            this.swlat.columnName = "lat";
            this.swlat.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swlat.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swlat.isForeignKey = false;
            this.swlat.Location = new System.Drawing.Point(1178, 647);
            this.swlat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swlat.Name = "swlat";
            this.swlat.required = true;
            this.swlat.Size = new System.Drawing.Size(148, 41);
            this.swlat.TabIndex = 53;
            // 
            // lblParsecs
            // 
            this.lblParsecs.AutoSize = true;
            this.lblParsecs.Location = new System.Drawing.Point(1053, 739);
            this.lblParsecs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParsecs.Name = "lblParsecs";
            this.lblParsecs.Size = new System.Drawing.Size(90, 25);
            this.lblParsecs.TabIndex = 59;
            this.lblParsecs.Text = "Parsecs";
            // 
            // swParsecs
            // 
            this.swParsecs.codiSW = null;
            this.swParsecs.columnName = "parsecs";
            this.swParsecs.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swParsecs.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swParsecs.isForeignKey = false;
            this.swParsecs.Location = new System.Drawing.Point(1178, 736);
            this.swParsecs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swParsecs.Name = "swParsecs";
            this.swParsecs.required = true;
            this.swParsecs.Size = new System.Drawing.Size(148, 41);
            this.swParsecs.TabIndex = 57;
            // 
            // frmPlanetsMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 944);
            this.Controls.Add(this.lblParsecs);
            this.Controls.Add(this.swParsecs);
            this.Controls.Add(this.lblPortPlanet1);
            this.Controls.Add(this.lbllat);
            this.Controls.Add(this.swPortPlanet1);
            this.Controls.Add(this.swlat);
            this.Controls.Add(this.lblPortPlanet);
            this.Controls.Add(this.lbllongPlan);
            this.Controls.Add(this.swPortPlanet);
            this.Controls.Add(this.swTextBox5);
            this.Controls.Add(this.lblIPPlanet);
            this.Controls.Add(this.lblDescriptionPlanets);
            this.Controls.Add(this.swIPPlanet);
            this.Controls.Add(this.swDescPlan);
            this.Controls.Add(this.lblNative);
            this.Controls.Add(this.swcodNative);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.lblFiliation);
            this.Controls.Add(this.lblImagePlan);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.swcodSector);
            this.Controls.Add(this.swcodFiliation);
            this.Controls.Add(this.swImagePlan);
            this.Controls.Add(this.swtxtCode);
            this.Controls.Add(this.swtxtCodiNative);
            this.Controls.Add(this.swtxtSector);
            this.Controls.Add(this.swtxtFiliation);
            this.Name = "frmPlanetsMant";
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
            this.Controls.SetChildIndex(this.lblImagePlan, 0);
            this.Controls.SetChildIndex(this.lblFiliation, 0);
            this.Controls.SetChildIndex(this.lblSector, 0);
            this.Controls.SetChildIndex(this.swcodNative, 0);
            this.Controls.SetChildIndex(this.lblNative, 0);
            this.Controls.SetChildIndex(this.swDescPlan, 0);
            this.Controls.SetChildIndex(this.swIPPlanet, 0);
            this.Controls.SetChildIndex(this.lblDescriptionPlanets, 0);
            this.Controls.SetChildIndex(this.lblIPPlanet, 0);
            this.Controls.SetChildIndex(this.swTextBox5, 0);
            this.Controls.SetChildIndex(this.swPortPlanet, 0);
            this.Controls.SetChildIndex(this.lbllongPlan, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet, 0);
            this.Controls.SetChildIndex(this.swlat, 0);
            this.Controls.SetChildIndex(this.swPortPlanet1, 0);
            this.Controls.SetChildIndex(this.lbllat, 0);
            this.Controls.SetChildIndex(this.lblPortPlanet1, 0);
            this.Controls.SetChildIndex(this.swParsecs, 0);
            this.Controls.SetChildIndex(this.lblParsecs, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox swtxtSector;
        private CustomControls.SWTextBox swtxtFiliation;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblFiliation;
        private System.Windows.Forms.Label lblImagePlan;
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
        private CustomControls.SWTextBox swTextBox5;
        private System.Windows.Forms.Label lblPortPlanet1;
        private System.Windows.Forms.Label lbllat;
        private CustomControls.SWTextBox swPortPlanet1;
        private CustomControls.SWTextBox swlat;
        private System.Windows.Forms.Label lblParsecs;
        private CustomControls.SWTextBox swParsecs;
    }
}