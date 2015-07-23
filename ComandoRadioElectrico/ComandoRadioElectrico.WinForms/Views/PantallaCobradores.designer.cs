namespace ComandoRadioElectrico.WinForms.Views
{
    partial class PantallaCobradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCobradores));
            this.tbDateLower = new System.Windows.Forms.TextBox();
            this.tbDateIn = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbDomicile = new System.Windows.Forms.TextBox();
            this.tbDocumentNumber = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgOfficer = new System.Windows.Forms.DataGridView();
            this.nombreSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbDocumentType = new System.Windows.Forms.ComboBox();
            this.tbPage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgOfficer)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDateLower
            // 
            this.tbDateLower.Location = new System.Drawing.Point(466, 89);
            this.tbDateLower.Name = "tbDateLower";
            this.tbDateLower.Size = new System.Drawing.Size(235, 20);
            this.tbDateLower.TabIndex = 53;
            // 
            // tbDateIn
            // 
            this.tbDateIn.Location = new System.Drawing.Point(466, 67);
            this.tbDateIn.Name = "tbDateIn";
            this.tbDateIn.Size = new System.Drawing.Size(235, 20);
            this.tbDateIn.TabIndex = 52;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(466, 45);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(235, 20);
            this.tbPhone.TabIndex = 49;
            // 
            // tbDomicile
            // 
            this.tbDomicile.Location = new System.Drawing.Point(466, 23);
            this.tbDomicile.Name = "tbDomicile";
            this.tbDomicile.Size = new System.Drawing.Size(235, 20);
            this.tbDomicile.TabIndex = 47;
            // 
            // tbDocumentNumber
            // 
            this.tbDocumentNumber.Location = new System.Drawing.Point(132, 92);
            this.tbDocumentNumber.Name = "tbDocumentNumber";
            this.tbDocumentNumber.Size = new System.Drawing.Size(235, 20);
            this.tbDocumentNumber.TabIndex = 46;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(132, 43);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(235, 20);
            this.tbLastName.TabIndex = 44;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(132, 21);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(235, 20);
            this.tbFirstName.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Fecha ingreso";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Fecha de baja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Domicilio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Número de documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tipo de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre";
            // 
            // dgOfficer
            // 
            this.dgOfficer.AllowUserToAddRows = false;
            this.dgOfficer.AllowUserToDeleteRows = false;
            this.dgOfficer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOfficer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreSocio,
            this.apellidoSocio,
            this.domicilioSocio,
            this.documentoSocio});
            this.dgOfficer.Location = new System.Drawing.Point(2, 170);
            this.dgOfficer.Name = "dgOfficer";
            this.dgOfficer.ReadOnly = true;
            this.dgOfficer.Size = new System.Drawing.Size(802, 207);
            this.dgOfficer.TabIndex = 30;
            // 
            // nombreSocio
            // 
            this.nombreSocio.HeaderText = "Nombre";
            this.nombreSocio.Name = "nombreSocio";
            this.nombreSocio.ReadOnly = true;
            this.nombreSocio.Width = 180;
            // 
            // apellidoSocio
            // 
            this.apellidoSocio.HeaderText = "Apellido";
            this.apellidoSocio.Name = "apellidoSocio";
            this.apellidoSocio.ReadOnly = true;
            this.apellidoSocio.Width = 180;
            // 
            // domicilioSocio
            // 
            this.domicilioSocio.HeaderText = "Domicilio";
            this.domicilioSocio.Name = "domicilioSocio";
            this.domicilioSocio.ReadOnly = true;
            this.domicilioSocio.Width = 250;
            // 
            // documentoSocio
            // 
            this.documentoSocio.HeaderText = "Documento";
            this.documentoSocio.Name = "documentoSocio";
            this.documentoSocio.ReadOnly = true;
            this.documentoSocio.Width = 148;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(717, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 62;
            this.button3.Text = "Baja";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(717, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 61;
            this.button4.Text = "Modificación";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(717, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 60;
            this.button2.Text = "Baja";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(717, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Alta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbDocumentType
            // 
            this.cbDocumentType.DisplayMember = "Type";
            this.cbDocumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumentType.FormattingEnabled = true;
            this.cbDocumentType.Location = new System.Drawing.Point(132, 66);
            this.cbDocumentType.Name = "cbDocumentType";
            this.cbDocumentType.Size = new System.Drawing.Size(235, 21);
            this.cbDocumentType.TabIndex = 63;
            this.cbDocumentType.ValueMember = "Id";
            // 
            // tbPage
            // 
            this.tbPage.Location = new System.Drawing.Point(594, 144);
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(100, 20);
            this.tbPage.TabIndex = 64;
            this.tbPage.Text = "1";
            // 
            // PantallaCobradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 381);
            this.Controls.Add(this.tbPage);
            this.Controls.Add(this.cbDocumentType);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDateLower);
            this.Controls.Add(this.tbDateIn);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbDomicile);
            this.Controls.Add(this.tbDocumentNumber);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgOfficer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaCobradores";
            this.Text = "Sistema de Gestión - Comando Radioeléctrico / Cobradores";
            this.Load += new System.EventHandler(this.PantallaCobradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOfficer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDateLower;
        private System.Windows.Forms.TextBox tbDateIn;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbDomicile;
        private System.Windows.Forms.TextBox tbDocumentNumber;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgOfficer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoSocio;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbDocumentType;
        private System.Windows.Forms.TextBox tbPage;

    }
}