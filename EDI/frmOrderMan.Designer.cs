
namespace EDI
{
    partial class frmOrderMan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderMan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblAgency = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.dtgDades = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtOrderCode = new System.Windows.Forms.TextBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.cbAgency = new System.Windows.Forms.ComboBox();
            this.lblOperationalArea = new System.Windows.Forms.Label();
            this.lblWarFactory = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlanet = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.swtxtFactoryCode = new CustomControls.SWTextBox();
            this.swtxtDescReference = new CustomControls.SWTextBox();
            this.swtxtPlanet = new CustomControls.SWTextBox();
            this.swtxtOrderDate = new CustomControls.SWTextBox();
            this.swtxtOperationalArea = new CustomControls.SWTextBox();
            this.swtxtDescFactory = new CustomControls.SWTextBox();
            this.swtxtQuantity = new CustomControls.SWTextBox();
            this.btnCarregarEdi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDades)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1197, 0);
            this.pbClose.Margin = new System.Windows.Forms.Padding(0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 23);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 21;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPriority.Location = new System.Drawing.Point(52, 182);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(70, 20);
            this.lblPriority.TabIndex = 23;
            this.lblPriority.Text = "Priority";
            // 
            // lblAgency
            // 
            this.lblAgency.AutoSize = true;
            this.lblAgency.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblAgency.Location = new System.Drawing.Point(49, 272);
            this.lblAgency.Name = "lblAgency";
            this.lblAgency.Size = new System.Drawing.Size(65, 20);
            this.lblAgency.TabIndex = 24;
            this.lblAgency.Text = "Agency";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(86, 454);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 20);
            this.lblQuantity.TabIndex = 25;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDeliveryDate.Location = new System.Drawing.Point(49, 412);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(115, 20);
            this.lblDeliveryDate.TabIndex = 26;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(52, 503);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 101;
            this.lblError.Visible = false;
            // 
            // dtgDades
            // 
            this.dtgDades.AllowUserToAddRows = false;
            this.dtgDades.AllowUserToDeleteRows = false;
            this.dtgDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDades.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgDades.Location = new System.Drawing.Point(53, 526);
            this.dtgDades.MultiSelect = false;
            this.dtgDades.Name = "dtgDades";
            this.dtgDades.ReadOnly = true;
            this.dtgDades.RowHeadersVisible = false;
            this.dtgDades.RowHeadersWidth = 51;
            this.dtgDades.RowTemplate.Height = 24;
            this.dtgDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDades.Size = new System.Drawing.Size(805, 269);
            this.dtgDades.StandardTab = true;
            this.dtgDades.TabIndex = 102;
            this.dtgDades.CurrentCellChanged += new System.EventHandler(this.dtgDades_CurrentCellChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnUpdate.CausesValidation = false;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(757, 815);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 39);
            this.btnUpdate.TabIndex = 107;
            this.btnUpdate.Text = "Save";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblOrderNumber.Location = new System.Drawing.Point(49, 126);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(124, 20);
            this.lblOrderNumber.TabIndex = 112;
            this.lblOrderNumber.Text = "Order Number";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.btnSearch.Location = new System.Drawing.Point(372, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 37);
            this.btnSearch.TabIndex = 113;
            this.btnSearch.Text = "Search Order";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtOrderCode
            // 
            this.txtOrderCode.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderCode.Location = new System.Drawing.Point(179, 123);
            this.txtOrderCode.Name = "txtOrderCode";
            this.txtOrderCode.Size = new System.Drawing.Size(170, 27);
            this.txtOrderCode.TabIndex = 116;
            // 
            // cbPriority
            // 
            this.cbPriority.DisplayMember = "idPriority";
            this.cbPriority.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(128, 179);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(340, 28);
            this.cbPriority.TabIndex = 117;
            this.cbPriority.Tag = "idPriority";
            // 
            // cbAgency
            // 
            this.cbAgency.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAgency.FormattingEnabled = true;
            this.cbAgency.Location = new System.Drawing.Point(118, 272);
            this.cbAgency.Name = "cbAgency";
            this.cbAgency.Size = new System.Drawing.Size(350, 28);
            this.cbAgency.TabIndex = 118;
            this.cbAgency.Tag = "idAgency";
            // 
            // lblOperationalArea
            // 
            this.lblOperationalArea.AutoSize = true;
            this.lblOperationalArea.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblOperationalArea.Location = new System.Drawing.Point(66, 315);
            this.lblOperationalArea.Name = "lblOperationalArea";
            this.lblOperationalArea.Size = new System.Drawing.Size(46, 20);
            this.lblOperationalArea.TabIndex = 119;
            this.lblOperationalArea.Text = "Area";
            // 
            // lblWarFactory
            // 
            this.lblWarFactory.AutoSize = true;
            this.lblWarFactory.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblWarFactory.Location = new System.Drawing.Point(497, 272);
            this.lblWarFactory.Name = "lblWarFactory";
            this.lblWarFactory.Size = new System.Drawing.Size(67, 20);
            this.lblWarFactory.TabIndex = 120;
            this.lblWarFactory.Text = "Factory";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblOrderDate.Location = new System.Drawing.Point(497, 182);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(96, 20);
            this.lblOrderDate.TabIndex = 124;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(46, 59);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 38);
            this.lblTitle.TabIndex = 125;
            this.lblTitle.Text = "Order";
            // 
            // lblPlanet
            // 
            this.lblPlanet.AutoSize = true;
            this.lblPlanet.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPlanet.Location = new System.Drawing.Point(398, 454);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(58, 20);
            this.lblPlanet.TabIndex = 126;
            this.lblPlanet.Text = "Planet";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblReference.Location = new System.Drawing.Point(368, 412);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(88, 20);
            this.lblReference.TabIndex = 128;
            this.lblReference.Text = "Reference";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Cambria", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblFrom.Location = new System.Drawing.Point(49, 236);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(71, 25);
            this.lblFrom.TabIndex = 132;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Cambria", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblTo.Location = new System.Drawing.Point(497, 233);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(41, 25);
            this.lblTo.TabIndex = 133;
            this.lblTo.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 134;
            this.label1.Text = "From:";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeliveryDate.Location = new System.Drawing.Point(168, 412);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(154, 27);
            this.dtpDeliveryDate.TabIndex = 135;
            this.dtpDeliveryDate.Tag = "DeliveryDate";
            this.dtpDeliveryDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDeliveryDate_Validating);
            // 
            // swtxtFactoryCode
            // 
            this.swtxtFactoryCode.codiSW = null;
            this.swtxtFactoryCode.columnName = "codeFactory";
            this.swtxtFactoryCode.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtFactoryCode.Enabled = false;
            this.swtxtFactoryCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtFactoryCode.isForeignKey = false;
            this.swtxtFactoryCode.Location = new System.Drawing.Point(570, 268);
            this.swtxtFactoryCode.Name = "swtxtFactoryCode";
            this.swtxtFactoryCode.required = false;
            this.swtxtFactoryCode.Size = new System.Drawing.Size(284, 29);
            this.swtxtFactoryCode.TabIndex = 131;
            // 
            // swtxtDescReference
            // 
            this.swtxtDescReference.codiSW = null;
            this.swtxtDescReference.columnName = "descReference";
            this.swtxtDescReference.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDescReference.Enabled = false;
            this.swtxtDescReference.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDescReference.isForeignKey = false;
            this.swtxtDescReference.Location = new System.Drawing.Point(462, 408);
            this.swtxtDescReference.Name = "swtxtDescReference";
            this.swtxtDescReference.required = false;
            this.swtxtDescReference.Size = new System.Drawing.Size(392, 29);
            this.swtxtDescReference.TabIndex = 129;
            // 
            // swtxtPlanet
            // 
            this.swtxtPlanet.codiSW = null;
            this.swtxtPlanet.columnName = "DescPlanet";
            this.swtxtPlanet.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtPlanet.Enabled = false;
            this.swtxtPlanet.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtPlanet.isForeignKey = false;
            this.swtxtPlanet.Location = new System.Drawing.Point(462, 450);
            this.swtxtPlanet.Name = "swtxtPlanet";
            this.swtxtPlanet.required = false;
            this.swtxtPlanet.Size = new System.Drawing.Size(392, 29);
            this.swtxtPlanet.TabIndex = 127;
            // 
            // swtxtOrderDate
            // 
            this.swtxtOrderDate.codiSW = null;
            this.swtxtOrderDate.columnName = "dateOrder";
            this.swtxtOrderDate.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtOrderDate.Enabled = false;
            this.swtxtOrderDate.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtOrderDate.isForeignKey = false;
            this.swtxtOrderDate.Location = new System.Drawing.Point(599, 178);
            this.swtxtOrderDate.Name = "swtxtOrderDate";
            this.swtxtOrderDate.required = false;
            this.swtxtOrderDate.Size = new System.Drawing.Size(112, 29);
            this.swtxtOrderDate.TabIndex = 123;
            // 
            // swtxtOperationalArea
            // 
            this.swtxtOperationalArea.codiSW = null;
            this.swtxtOperationalArea.columnName = "DescOperationalArea";
            this.swtxtOperationalArea.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtOperationalArea.Enabled = false;
            this.swtxtOperationalArea.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtOperationalArea.isForeignKey = false;
            this.swtxtOperationalArea.Location = new System.Drawing.Point(118, 311);
            this.swtxtOperationalArea.Name = "swtxtOperationalArea";
            this.swtxtOperationalArea.required = false;
            this.swtxtOperationalArea.Size = new System.Drawing.Size(158, 29);
            this.swtxtOperationalArea.TabIndex = 122;
            // 
            // swtxtDescFactory
            // 
            this.swtxtDescFactory.codiSW = null;
            this.swtxtDescFactory.columnName = "DescFactory";
            this.swtxtDescFactory.dadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swtxtDescFactory.Enabled = false;
            this.swtxtDescFactory.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtDescFactory.isForeignKey = false;
            this.swtxtDescFactory.Location = new System.Drawing.Point(502, 311);
            this.swtxtDescFactory.Name = "swtxtDescFactory";
            this.swtxtDescFactory.required = false;
            this.swtxtDescFactory.Size = new System.Drawing.Size(352, 29);
            this.swtxtDescFactory.TabIndex = 121;
            // 
            // swtxtQuantity
            // 
            this.swtxtQuantity.codiSW = null;
            this.swtxtQuantity.columnName = "Quantity";
            this.swtxtQuantity.dadaPermesa = CustomControls.SWTextBox.TipusDada.Nombre;
            this.swtxtQuantity.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swtxtQuantity.isForeignKey = false;
            this.swtxtQuantity.Location = new System.Drawing.Point(168, 450);
            this.swtxtQuantity.Name = "swtxtQuantity";
            this.swtxtQuantity.required = true;
            this.swtxtQuantity.Size = new System.Drawing.Size(154, 29);
            this.swtxtQuantity.TabIndex = 28;
            this.swtxtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.swtxtQuantity_Validating);
            // 
            // btnCarregarEdi
            // 
            this.btnCarregarEdi.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarEdi.Location = new System.Drawing.Point(757, 113);
            this.btnCarregarEdi.Name = "btnCarregarEdi";
            this.btnCarregarEdi.Size = new System.Drawing.Size(97, 37);
            this.btnCarregarEdi.TabIndex = 136;
            this.btnCarregarEdi.Text = "Load EDI";
            this.btnCarregarEdi.UseVisualStyleBackColor = true;
            this.btnCarregarEdi.Click += new System.EventHandler(this.btnCarregarEdi_Click);
            // 
            // frmOrderMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1222, 904);
            this.Controls.Add(this.btnCarregarEdi);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.swtxtFactoryCode);
            this.Controls.Add(this.swtxtDescReference);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.swtxtPlanet);
            this.Controls.Add(this.lblPlanet);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.swtxtOrderDate);
            this.Controls.Add(this.swtxtOperationalArea);
            this.Controls.Add(this.swtxtDescFactory);
            this.Controls.Add(this.lblWarFactory);
            this.Controls.Add(this.lblOperationalArea);
            this.Controls.Add(this.cbAgency);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.txtOrderCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dtgDades);
            this.Controls.Add(this.swtxtQuantity);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblAgency);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.pbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderMan";
            this.Text = "a";
            this.Load += new System.EventHandler(this.frmOrderMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblAgency;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDeliveryDate;
        private CustomControls.SWTextBox swtxtQuantity;
        private System.Windows.Forms.Label lblError;
        protected System.Windows.Forms.DataGridView dtgDades;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtOrderCode;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.ComboBox cbAgency;
        private System.Windows.Forms.Label lblOperationalArea;
        private System.Windows.Forms.Label lblWarFactory;
        private CustomControls.SWTextBox swtxtDescFactory;
        private CustomControls.SWTextBox swtxtOperationalArea;
        private CustomControls.SWTextBox swtxtOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlanet;
        private CustomControls.SWTextBox swtxtPlanet;
        private System.Windows.Forms.Label lblReference;
        private CustomControls.SWTextBox swtxtDescReference;
        private CustomControls.SWTextBox swtxtFactoryCode;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Button btnCarregarEdi;
    }
}