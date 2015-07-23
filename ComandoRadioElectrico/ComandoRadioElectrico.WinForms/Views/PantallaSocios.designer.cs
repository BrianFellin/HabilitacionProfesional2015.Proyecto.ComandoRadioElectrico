using System.Windows.Forms;
namespace ComandoRadioElectrico.WinForms.Views
{
    partial class PantallaSocios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaSocios));
            this.DataGridViewPartner = new System.Windows.Forms.DataGridView();
            this.nombreSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelValueQuota = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDocumentType = new System.Windows.Forms.Label();
            this.labelDocumentNumber = new System.Windows.Forms.Label();
            this.labelCollectDomicile = new System.Windows.Forms.Label();
            this.labelDomicile = new System.Windows.Forms.Label();
            this.labelOfficer = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelStarDate = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.labelCollectDay = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbCollectDomicile = new System.Windows.Forms.TextBox();
            this.tbDomicile = new System.Windows.Forms.TextBox();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.tbValueQuota = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.cbDocumentType = new System.Windows.Forms.ComboBox();
            this.cbOfficer = new System.Windows.Forms.ComboBox();
            this.labelMessaError = new System.Windows.Forms.Label();
            this.FirstNameError = new System.Windows.Forms.PictureBox();
            this.LastNameError = new System.Windows.Forms.PictureBox();
            this.DocumentNumberError = new System.Windows.Forms.PictureBox();
            this.DomicileError = new System.Windows.Forms.PictureBox();
            this.CollectDomicileError = new System.Windows.Forms.PictureBox();
            this.TelephoneError = new System.Windows.Forms.PictureBox();
            this.ValueQuotaError = new System.Windows.Forms.PictureBox();
            this.cbDel = new System.Windows.Forms.ComboBox();
            this.LabelAl = new System.Windows.Forms.Label();
            this.labelDel = new System.Windows.Forms.Label();
            this.cbAl = new System.Windows.Forms.ComboBox();
            this.mtDocumentNumber = new System.Windows.Forms.MaskedTextBox();
            this.tbIdPartnerSelected = new System.Windows.Forms.TextBox();
            this.bRestore = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.bBack = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPartner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentNumberError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DomicileError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollectDomicileError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueQuotaError)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewPartner
            // 
            this.DataGridViewPartner.AllowUserToAddRows = false;
            this.DataGridViewPartner.AllowUserToDeleteRows = false;
            this.DataGridViewPartner.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewPartner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPartner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreSocio,
            this.apellidoSocio,
            this.domicilioSocio,
            this.documentoSocio,
            this.Id,
            this.Seleccionar});
            this.DataGridViewPartner.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewPartner.Location = new System.Drawing.Point(6, 193);
            this.DataGridViewPartner.Name = "DataGridViewPartner";
            this.DataGridViewPartner.ReadOnly = true;
            this.DataGridViewPartner.Size = new System.Drawing.Size(863, 307);
            this.DataGridViewPartner.TabIndex = 1;
            this.DataGridViewPartner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPartner_CellContentClick);
            // 
            // nombreSocio
            // 
            this.nombreSocio.DataPropertyName = "FirstName";
            this.nombreSocio.HeaderText = "Nombre";
            this.nombreSocio.Name = "nombreSocio";
            this.nombreSocio.ReadOnly = true;
            this.nombreSocio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombreSocio.ToolTipText = "1";
            this.nombreSocio.Width = 180;
            // 
            // apellidoSocio
            // 
            this.apellidoSocio.DataPropertyName = "LastName";
            this.apellidoSocio.HeaderText = "Apellido";
            this.apellidoSocio.Name = "apellidoSocio";
            this.apellidoSocio.ReadOnly = true;
            this.apellidoSocio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.apellidoSocio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.apellidoSocio.Width = 180;
            // 
            // domicilioSocio
            // 
            this.domicilioSocio.DataPropertyName = "Domicile";
            this.domicilioSocio.HeaderText = "Domicilio";
            this.domicilioSocio.Name = "domicilioSocio";
            this.domicilioSocio.ReadOnly = true;
            this.domicilioSocio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.domicilioSocio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.domicilioSocio.Width = 250;
            // 
            // documentoSocio
            // 
            this.documentoSocio.DataPropertyName = "Document";
            this.documentoSocio.HeaderText = "Documento";
            this.documentoSocio.Name = "documentoSocio";
            this.documentoSocio.ReadOnly = true;
            this.documentoSocio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.documentoSocio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.documentoSocio.Width = 130;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // Seleccionar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Seleccionar";
            this.Seleccionar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Seleccionar.Text = "";
            this.Seleccionar.ToolTipText = "Seleccionar";
            this.Seleccionar.Width = 80;
            // 
            // labelValueQuota
            // 
            this.labelValueQuota.AutoSize = true;
            this.labelValueQuota.Location = new System.Drawing.Point(394, 53);
            this.labelValueQuota.Name = "labelValueQuota";
            this.labelValueQuota.Size = new System.Drawing.Size(98, 13);
            this.labelValueQuota.TabIndex = 2;
            this.labelValueQuota.Text = "Importe de la cuota";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(79, 31);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(44, 13);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "Nombre";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(79, 53);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(44, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Apellido";
            // 
            // labelDocumentType
            // 
            this.labelDocumentType.AutoSize = true;
            this.labelDocumentType.Location = new System.Drawing.Point(24, 76);
            this.labelDocumentType.Name = "labelDocumentType";
            this.labelDocumentType.Size = new System.Drawing.Size(99, 13);
            this.labelDocumentType.TabIndex = 5;
            this.labelDocumentType.Text = "Tipo de documento";
            // 
            // labelDocumentNumber
            // 
            this.labelDocumentNumber.AutoSize = true;
            this.labelDocumentNumber.Location = new System.Drawing.Point(8, 97);
            this.labelDocumentNumber.Name = "labelDocumentNumber";
            this.labelDocumentNumber.Size = new System.Drawing.Size(115, 13);
            this.labelDocumentNumber.TabIndex = 6;
            this.labelDocumentNumber.Text = "Número de documento";
            // 
            // labelCollectDomicile
            // 
            this.labelCollectDomicile.AutoSize = true;
            this.labelCollectDomicile.Location = new System.Drawing.Point(29, 141);
            this.labelCollectDomicile.Name = "labelCollectDomicile";
            this.labelCollectDomicile.Size = new System.Drawing.Size(94, 13);
            this.labelCollectDomicile.TabIndex = 7;
            this.labelCollectDomicile.Text = "Domicilio de cobro";
            // 
            // labelDomicile
            // 
            this.labelDomicile.AutoSize = true;
            this.labelDomicile.Location = new System.Drawing.Point(74, 121);
            this.labelDomicile.Name = "labelDomicile";
            this.labelDomicile.Size = new System.Drawing.Size(49, 13);
            this.labelDomicile.TabIndex = 8;
            this.labelDomicile.Text = "Domicilio";
            // 
            // labelOfficer
            // 
            this.labelOfficer.AutoSize = true;
            this.labelOfficer.Location = new System.Drawing.Point(442, 97);
            this.labelOfficer.Name = "labelOfficer";
            this.labelOfficer.Size = new System.Drawing.Size(50, 13);
            this.labelOfficer.TabIndex = 9;
            this.labelOfficer.Text = "Cobrador";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(443, 32);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(49, 13);
            this.labelTelephone.TabIndex = 10;
            this.labelTelephone.Text = "Teléfono";
            // 
            // labelStarDate
            // 
            this.labelStarDate.AutoSize = true;
            this.labelStarDate.Location = new System.Drawing.Point(418, 76);
            this.labelStarDate.Name = "labelStarDate";
            this.labelStarDate.Size = new System.Drawing.Size(74, 13);
            this.labelStarDate.TabIndex = 11;
            this.labelStarDate.Text = "Fecha ingreso";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(129, 28);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(235, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // labelCollectDay
            // 
            this.labelCollectDay.AutoSize = true;
            this.labelCollectDay.Location = new System.Drawing.Point(400, 122);
            this.labelCollectDay.Name = "labelCollectDay";
            this.labelCollectDay.Size = new System.Drawing.Size(92, 13);
            this.labelCollectDay.TabIndex = 14;
            this.labelCollectDay.Text = "Días de cobranza";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(129, 50);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(235, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // tbCollectDomicile
            // 
            this.tbCollectDomicile.Location = new System.Drawing.Point(129, 138);
            this.tbCollectDomicile.Name = "tbCollectDomicile";
            this.tbCollectDomicile.Size = new System.Drawing.Size(235, 20);
            this.tbCollectDomicile.TabIndex = 5;
            // 
            // tbDomicile
            // 
            this.tbDomicile.Location = new System.Drawing.Point(129, 116);
            this.tbDomicile.Name = "tbDomicile";
            this.tbDomicile.Size = new System.Drawing.Size(235, 20);
            this.tbDomicile.TabIndex = 4;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(498, 73);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.ReadOnly = true;
            this.tbStartDate.Size = new System.Drawing.Size(235, 20);
            this.tbStartDate.TabIndex = 23;
            this.tbStartDate.TabStop = false;
            // 
            // tbValueQuota
            // 
            this.tbValueQuota.Location = new System.Drawing.Point(498, 50);
            this.tbValueQuota.Name = "tbValueQuota";
            this.tbValueQuota.Size = new System.Drawing.Size(235, 20);
            this.tbValueQuota.TabIndex = 7;
            this.tbValueQuota.Text = "0";
            this.tbValueQuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValueQuota_KeyPress);
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(498, 29);
            this.tbTelephone.MaxLength = 20;
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(235, 20);
            this.tbTelephone.TabIndex = 6;
            this.tbTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelephone_KeyPress);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Red;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancel.Location = new System.Drawing.Point(776, 130);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 62;
            this.bCancel.Text = "Cancelar";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.BackColor = System.Drawing.Color.Teal;
            this.bUpdate.Enabled = false;
            this.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bUpdate.Location = new System.Drawing.Point(776, 97);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 61;
            this.bUpdate.Text = "Modificación";
            this.bUpdate.UseVisualStyleBackColor = false;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bDelete.Enabled = false;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDelete.Location = new System.Drawing.Point(776, 64);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 60;
            this.bDelete.Text = "Baja";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bNew
            // 
            this.bNew.BackColor = System.Drawing.Color.DodgerBlue;
            this.bNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bNew.Location = new System.Drawing.Point(776, 31);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 59;
            this.bNew.Text = "Alta";
            this.bNew.UseVisualStyleBackColor = false;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // cbDocumentType
            // 
            this.cbDocumentType.DisplayMember = "Type";
            this.cbDocumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumentType.FormattingEnabled = true;
            this.cbDocumentType.Location = new System.Drawing.Point(129, 71);
            this.cbDocumentType.Name = "cbDocumentType";
            this.cbDocumentType.Size = new System.Drawing.Size(235, 21);
            this.cbDocumentType.TabIndex = 63;
            this.cbDocumentType.TabStop = false;
            this.cbDocumentType.ValueMember = "Id";
            // 
            // cbOfficer
            // 
            this.cbOfficer.DisplayMember = "FirstName";
            this.cbOfficer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOfficer.FormattingEnabled = true;
            this.cbOfficer.Location = new System.Drawing.Point(498, 94);
            this.cbOfficer.Name = "cbOfficer";
            this.cbOfficer.Size = new System.Drawing.Size(235, 21);
            this.cbOfficer.TabIndex = 64;
            this.cbOfficer.TabStop = false;
            this.cbOfficer.ValueMember = "Id";
            // 
            // labelMessaError
            // 
            this.labelMessaError.AutoSize = true;
            this.labelMessaError.ForeColor = System.Drawing.Color.Red;
            this.labelMessaError.Location = new System.Drawing.Point(569, 5);
            this.labelMessaError.Name = "labelMessaError";
            this.labelMessaError.Size = new System.Drawing.Size(0, 13);
            this.labelMessaError.TabIndex = 65;
            this.labelMessaError.Visible = false;
            // 
            // FirstNameError
            // 
            this.FirstNameError.Image = global::ComandoRadioElectrico.WinForms.Properties.Resources.iconoAdvertencia;
            this.FirstNameError.Location = new System.Drawing.Point(370, 30);
            this.FirstNameError.Name = "FirstNameError";
            this.FirstNameError.Size = new System.Drawing.Size(18, 18);
            this.FirstNameError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FirstNameError.TabIndex = 66;
            this.FirstNameError.TabStop = false;
            this.FirstNameError.Visible = false;
            // 
            // LastNameError
            // 
            this.LastNameError.Image = global::ComandoRadioElectrico.WinForms.Properties.Resources.iconoAdvertencia;
            this.LastNameError.Location = new System.Drawing.Point(370, 52);
            this.LastNameError.Name = "LastNameError";
            this.LastNameError.Size = new System.Drawing.Size(18, 18);
            this.LastNameError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LastNameError.TabIndex = 67;
            this.LastNameError.TabStop = false;
            this.LastNameError.Visible = false;
            // 
            // DocumentNumberError
            // 
            this.DocumentNumberError.Image = global::ComandoRadioElectrico.WinForms.Properties.Resources.iconoAdvertencia;
            this.DocumentNumberError.Location = new System.Drawing.Point(370, 96);
            this.DocumentNumberError.Name = "DocumentNumberError";
            this.DocumentNumberError.Size = new System.Drawing.Size(18, 18);
            this.DocumentNumberError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DocumentNumberError.TabIndex = 68;
            this.DocumentNumberError.TabStop = false;
            this.DocumentNumberError.Visible = false;
            // 
            // DomicileError
            // 
            this.DomicileError.Image = global::ComandoRadioElectrico.WinForms.Properties.Resources.iconoAdvertencia;
            this.DomicileError.Location = new System.Drawing.Point(370, 118);
            this.DomicileError.Name = "DomicileError";
            this.DomicileError.Size = new System.Drawing.Size(18, 18);
            this.DomicileError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DomicileError.TabIndex = 69;
            this.DomicileError.TabStop = false;
            this.DomicileError.Visible = false;
            // 
            // CollectDomicileError
            // 
            this.CollectDomicileError.Image = global::ComandoRadioElectrico.WinForms.Properties.Resources.iconoAdvertencia;
            this.CollectDomicileError.Location = new System.Drawing.Point(370, 140);
            this.CollectDomicileError.Name = "CollectDomicileError";
            this.CollectDomicileError.Size = new System.Drawing.Size(18, 18);
            this.CollectDomicileError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CollectDomicileError.TabIndex = 70;
            this.CollectDomicileError.TabStop = false;
            this.CollectDomicileError.Visible = false;
            // 
            // TelephoneError
            // 
            this.TelephoneError.Image = global::ComandoRadioElectrico.WinForms.Properties.Resources.iconoAdvertencia;
            this.TelephoneError.Location = new System.Drawing.Point(739, 30);
            this.TelephoneError.Name = "TelephoneError";
            this.TelephoneError.Size = new System.Drawing.Size(18, 18);
            this.TelephoneError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TelephoneError.TabIndex = 71;
            this.TelephoneError.TabStop = false;
            this.TelephoneError.Visible = false;
            // 
            // ValueQuotaError
            // 
            this.ValueQuotaError.Image = global::ComandoRadioElectrico.WinForms.Properties.Resources.iconoAdvertencia;
            this.ValueQuotaError.Location = new System.Drawing.Point(739, 52);
            this.ValueQuotaError.Name = "ValueQuotaError";
            this.ValueQuotaError.Size = new System.Drawing.Size(18, 18);
            this.ValueQuotaError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ValueQuotaError.TabIndex = 72;
            this.ValueQuotaError.TabStop = false;
            this.ValueQuotaError.Visible = false;
            // 
            // cbDel
            // 
            this.cbDel.DisplayMember = "Id";
            this.cbDel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDel.FormattingEnabled = true;
            this.cbDel.Location = new System.Drawing.Point(527, 118);
            this.cbDel.Name = "cbDel";
            this.cbDel.Size = new System.Drawing.Size(91, 21);
            this.cbDel.TabIndex = 76;
            this.cbDel.TabStop = false;
            this.cbDel.ValueMember = "Id";
            this.cbDel.SelectedValueChanged += new System.EventHandler(this.cbDel_SelectedValueChanged);
            // 
            // LabelAl
            // 
            this.LabelAl.AutoSize = true;
            this.LabelAl.Location = new System.Drawing.Point(624, 122);
            this.LabelAl.Name = "LabelAl";
            this.LabelAl.Size = new System.Drawing.Size(15, 13);
            this.LabelAl.TabIndex = 77;
            this.LabelAl.Text = "al";
            // 
            // labelDel
            // 
            this.labelDel.AutoSize = true;
            this.labelDel.Location = new System.Drawing.Point(498, 122);
            this.labelDel.Name = "labelDel";
            this.labelDel.Size = new System.Drawing.Size(23, 13);
            this.labelDel.TabIndex = 78;
            this.labelDel.Text = "Del";
            // 
            // cbAl
            // 
            this.cbAl.DisplayMember = "Id";
            this.cbAl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAl.FormattingEnabled = true;
            this.cbAl.Location = new System.Drawing.Point(642, 118);
            this.cbAl.Name = "cbAl";
            this.cbAl.Size = new System.Drawing.Size(91, 21);
            this.cbAl.TabIndex = 79;
            this.cbAl.TabStop = false;
            this.cbAl.ValueMember = "Id";
            // 
            // mtDocumentNumber
            // 
            this.mtDocumentNumber.Location = new System.Drawing.Point(129, 94);
            this.mtDocumentNumber.Mask = "99.999.999";
            this.mtDocumentNumber.Name = "mtDocumentNumber";
            this.mtDocumentNumber.Size = new System.Drawing.Size(235, 20);
            this.mtDocumentNumber.TabIndex = 3;
            // 
            // tbIdPartnerSelected
            // 
            this.tbIdPartnerSelected.Location = new System.Drawing.Point(527, 147);
            this.tbIdPartnerSelected.Name = "tbIdPartnerSelected";
            this.tbIdPartnerSelected.Size = new System.Drawing.Size(44, 20);
            this.tbIdPartnerSelected.TabIndex = 80;
            this.tbIdPartnerSelected.Visible = false;
            // 
            // bRestore
            // 
            this.bRestore.BackColor = System.Drawing.Color.Transparent;
            this.bRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRestore.Image = ((System.Drawing.Image)(resources.GetObject("bRestore.Image")));
            this.bRestore.Location = new System.Drawing.Point(776, 31);
            this.bRestore.Name = "bRestore";
            this.bRestore.Size = new System.Drawing.Size(29, 23);
            this.bRestore.TabIndex = 81;
            this.bRestore.UseVisualStyleBackColor = false;
            this.bRestore.Visible = false;
            this.bRestore.Click += new System.EventHandler(this.bRestore_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(129, 167);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(398, 20);
            this.tbSearch.TabIndex = 82;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // tbPage
            // 
            this.tbPage.Location = new System.Drawing.Point(829, 506);
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(29, 20);
            this.tbPage.TabIndex = 85;
            this.tbPage.Text = "1";
            // 
            // bBack
            // 
            this.bBack.Enabled = false;
            this.bBack.Location = new System.Drawing.Point(587, 506);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 84;
            this.bBack.Text = "Atras";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(690, 506);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(75, 23);
            this.bNext.TabIndex = 83;
            this.bNext.Text = "Sig.";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // PantallaSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 540);
            this.Controls.Add(this.tbPage);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.bRestore);
            this.Controls.Add(this.tbIdPartnerSelected);
            this.Controls.Add(this.mtDocumentNumber);
            this.Controls.Add(this.cbAl);
            this.Controls.Add(this.labelDel);
            this.Controls.Add(this.LabelAl);
            this.Controls.Add(this.cbDel);
            this.Controls.Add(this.ValueQuotaError);
            this.Controls.Add(this.TelephoneError);
            this.Controls.Add(this.CollectDomicileError);
            this.Controls.Add(this.DomicileError);
            this.Controls.Add(this.DocumentNumberError);
            this.Controls.Add(this.LastNameError);
            this.Controls.Add(this.FirstNameError);
            this.Controls.Add(this.labelMessaError);
            this.Controls.Add(this.cbOfficer);
            this.Controls.Add(this.DataGridViewPartner);
            this.Controls.Add(this.cbDocumentType);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.tbValueQuota);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbCollectDomicile);
            this.Controls.Add(this.tbDomicile);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.labelCollectDay);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.labelStarDate);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.labelOfficer);
            this.Controls.Add(this.labelDomicile);
            this.Controls.Add(this.labelCollectDomicile);
            this.Controls.Add(this.labelDocumentNumber);
            this.Controls.Add(this.labelDocumentType);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelValueQuota);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaSocios";
            this.Text = "Sistema de Gestión - Comando Radioeléctrico / Socios";
            this.Load += new System.EventHandler(this.PantallaSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPartner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentNumberError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DomicileError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollectDomicileError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueQuotaError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewPartner;
        private System.Windows.Forms.Label labelValueQuota;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDocumentType;
        private System.Windows.Forms.Label labelDocumentNumber;
        private System.Windows.Forms.Label labelCollectDomicile;
        private System.Windows.Forms.Label labelDomicile;
        private System.Windows.Forms.Label labelOfficer;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelStarDate;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label labelCollectDay;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbCollectDomicile;
        private System.Windows.Forms.TextBox tbDomicile;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.TextBox tbValueQuota;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.ComboBox cbDocumentType;
        private ComboBox cbOfficer;
        private DataGridViewTextBoxColumn nombreSocio;
        private DataGridViewTextBoxColumn apellidoSocio;
        private DataGridViewTextBoxColumn domicilioSocio;
        private DataGridViewTextBoxColumn documentoSocio;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewButtonColumn Seleccionar;
        private Label labelMessaError;
        private PictureBox FirstNameError;
        private PictureBox LastNameError;
        private PictureBox DocumentNumberError;
        private PictureBox DomicileError;
        private PictureBox CollectDomicileError;
        private PictureBox TelephoneError;
        private PictureBox ValueQuotaError;
        private ComboBox cbDel;
        private Label LabelAl;
        private Label labelDel;
        private ComboBox cbAl;
        private MaskedTextBox mtDocumentNumber;
        private TextBox tbIdPartnerSelected;
        private Button bRestore;
        private TextBox tbSearch;
        private TextBox tbPage;
        private Button bBack;
        private Button bNext;
    }
}