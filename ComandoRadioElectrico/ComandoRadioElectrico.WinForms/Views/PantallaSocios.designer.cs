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
            this.DataGridViewSocios = new System.Windows.Forms.DataGridView();
            this.nombreSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
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
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentNumberError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DomicileError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollectDomicileError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueQuotaError)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewSocios
            // 
            this.DataGridViewSocios.AllowUserToAddRows = false;
            this.DataGridViewSocios.AllowUserToDeleteRows = false;
            this.DataGridViewSocios.AllowUserToOrderColumns = true;
            this.DataGridViewSocios.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreSocio,
            this.apellidoSocio,
            this.domicilioSocio,
            this.documentoSocio,
            this.Id,
            this.Seleccionar});
            this.DataGridViewSocios.GridColor = System.Drawing.Color.Gray;
            this.DataGridViewSocios.Location = new System.Drawing.Point(6, 181);
            this.DataGridViewSocios.Name = "DataGridViewSocios";
            this.DataGridViewSocios.ReadOnly = true;
            this.DataGridViewSocios.Size = new System.Drawing.Size(863, 319);
            this.DataGridViewSocios.TabIndex = 1;
            this.DataGridViewSocios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSocios_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Importe de la cuota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Número de documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Domicilio de cobro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Domicilio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cobrador";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Teléfono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Fecha ingreso";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(129, 36);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(235, 20);
            this.tbFirstName.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(400, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Días de cobranza";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(129, 58);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(235, 20);
            this.tbLastName.TabIndex = 15;
            // 
            // tbCollectDomicile
            // 
            this.tbCollectDomicile.Location = new System.Drawing.Point(129, 146);
            this.tbCollectDomicile.Name = "tbCollectDomicile";
            this.tbCollectDomicile.Size = new System.Drawing.Size(235, 20);
            this.tbCollectDomicile.TabIndex = 19;
            // 
            // tbDomicile
            // 
            this.tbDomicile.Location = new System.Drawing.Point(129, 124);
            this.tbDomicile.Name = "tbDomicile";
            this.tbDomicile.Size = new System.Drawing.Size(235, 20);
            this.tbDomicile.TabIndex = 18;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(498, 81);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.ReadOnly = true;
            this.tbStartDate.Size = new System.Drawing.Size(235, 20);
            this.tbStartDate.TabIndex = 23;
            // 
            // tbValueQuota
            // 
            this.tbValueQuota.Location = new System.Drawing.Point(498, 58);
            this.tbValueQuota.Name = "tbValueQuota";
            this.tbValueQuota.Size = new System.Drawing.Size(235, 20);
            this.tbValueQuota.TabIndex = 21;
            this.tbValueQuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValueQuota_KeyPress);
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(498, 37);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(235, 20);
            this.tbTelephone.TabIndex = 20;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Red;
            this.bCancel.Enabled = false;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancel.Location = new System.Drawing.Point(776, 138);
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
            this.bUpdate.Location = new System.Drawing.Point(776, 105);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 61;
            this.bUpdate.Text = "Modificación";
            this.bUpdate.UseVisualStyleBackColor = false;
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bDelete.Enabled = false;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDelete.Location = new System.Drawing.Point(776, 72);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 60;
            this.bDelete.Text = "Baja";
            this.bDelete.UseVisualStyleBackColor = false;
            // 
            // bNew
            // 
            this.bNew.BackColor = System.Drawing.Color.DodgerBlue;
            this.bNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bNew.Location = new System.Drawing.Point(776, 39);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 59;
            this.bNew.Text = "Alta";
            this.bNew.UseVisualStyleBackColor = false;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.DisplayMember = "Type";
            this.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(129, 79);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(235, 21);
            this.cbTipoDocumento.TabIndex = 63;
            this.cbTipoDocumento.ValueMember = "Id";
            // 
            // cbOfficer
            // 
            this.cbOfficer.DisplayMember = "FirstName";
            this.cbOfficer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOfficer.FormattingEnabled = true;
            this.cbOfficer.Location = new System.Drawing.Point(498, 102);
            this.cbOfficer.Name = "cbOfficer";
            this.cbOfficer.Size = new System.Drawing.Size(235, 21);
            this.cbOfficer.TabIndex = 64;
            this.cbOfficer.ValueMember = "Id";
            // 
            // labelMessaError
            // 
            this.labelMessaError.AutoSize = true;
            this.labelMessaError.ForeColor = System.Drawing.Color.Red;
            this.labelMessaError.Location = new System.Drawing.Point(569, 13);
            this.labelMessaError.Name = "labelMessaError";
            this.labelMessaError.Size = new System.Drawing.Size(0, 13);
            this.labelMessaError.TabIndex = 65;
            this.labelMessaError.Visible = false;
            // 
            // FirstNameError
            // 
            this.FirstNameError.Image = global::ComandoRadioElectrico.WinForms.Properties.Resources.iconoAdvertencia;
            this.FirstNameError.Location = new System.Drawing.Point(370, 38);
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
            this.LastNameError.Location = new System.Drawing.Point(370, 60);
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
            this.DocumentNumberError.Location = new System.Drawing.Point(370, 104);
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
            this.DomicileError.Location = new System.Drawing.Point(370, 126);
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
            this.CollectDomicileError.Location = new System.Drawing.Point(370, 148);
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
            this.TelephoneError.Location = new System.Drawing.Point(739, 38);
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
            this.ValueQuotaError.Location = new System.Drawing.Point(739, 60);
            this.ValueQuotaError.Name = "ValueQuotaError";
            this.ValueQuotaError.Size = new System.Drawing.Size(18, 18);
            this.ValueQuotaError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ValueQuotaError.TabIndex = 72;
            this.ValueQuotaError.TabStop = false;
            this.ValueQuotaError.Visible = false;
            // 
            // cbDel
            // 
            this.cbDel.DisplayMember = "FirstName";
            this.cbDel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDel.FormattingEnabled = true;
            this.cbDel.Location = new System.Drawing.Point(527, 126);
            this.cbDel.Name = "cbDel";
            this.cbDel.Size = new System.Drawing.Size(91, 21);
            this.cbDel.TabIndex = 76;
            this.cbDel.ValueMember = "Id";
            this.cbDel.SelectedValueChanged += new System.EventHandler(this.cbDel_SelectedValueChanged);
            // 
            // LabelAl
            // 
            this.LabelAl.AutoSize = true;
            this.LabelAl.Location = new System.Drawing.Point(624, 130);
            this.LabelAl.Name = "LabelAl";
            this.LabelAl.Size = new System.Drawing.Size(15, 13);
            this.LabelAl.TabIndex = 77;
            this.LabelAl.Text = "al";
            // 
            // labelDel
            // 
            this.labelDel.AutoSize = true;
            this.labelDel.Location = new System.Drawing.Point(498, 130);
            this.labelDel.Name = "labelDel";
            this.labelDel.Size = new System.Drawing.Size(23, 13);
            this.labelDel.TabIndex = 78;
            this.labelDel.Text = "Del";
            // 
            // cbAl
            // 
            this.cbAl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAl.FormattingEnabled = true;
            this.cbAl.Location = new System.Drawing.Point(642, 126);
            this.cbAl.Name = "cbAl";
            this.cbAl.Size = new System.Drawing.Size(91, 21);
            this.cbAl.TabIndex = 79;
            // 
            // mtDocumentNumber
            // 
            this.mtDocumentNumber.Location = new System.Drawing.Point(129, 102);
            this.mtDocumentNumber.Mask = "99.999.999";
            this.mtDocumentNumber.Name = "mtDocumentNumber";
            this.mtDocumentNumber.Size = new System.Drawing.Size(235, 20);
            this.mtDocumentNumber.TabIndex = 80;
            // 
            // PantallaSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 503);
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
            this.Controls.Add(this.DataGridViewSocios);
            this.Controls.Add(this.cbTipoDocumento);
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
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaSocios";
            this.Text = "Sistema de Gestión - Comando Radioeléctrico / Socios";
            this.Load += new System.EventHandler(this.PantallaSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSocios)).EndInit();
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

        private System.Windows.Forms.DataGridView DataGridViewSocios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.ComboBox cbTipoDocumento;
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
    }
}