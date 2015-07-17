namespace Pantallas
{
    partial class PantallaCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCuentas));
            this.bCancel = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgAccountantAccount = new System.Windows.Forms.DataGridView();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.codeError = new System.Windows.Forms.PictureBox();
            this.nameError = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selection = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountantAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Enabled = false;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancel.Location = new System.Drawing.Point(717, 99);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 9;
            this.bCancel.Text = "Cancelar";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Enabled = false;
            this.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bUpdate.Location = new System.Drawing.Point(717, 75);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 8;
            this.bUpdate.Text = "Modificación";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.Enabled = false;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDelete.Location = new System.Drawing.Point(717, 51);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 7;
            this.bDelete.Text = "Baja";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bNew
            // 
            this.bNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bNew.Location = new System.Drawing.Point(717, 27);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 6;
            this.bNew.Text = "Alta";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(432, 56);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(235, 20);
            this.tbAmount.TabIndex = 5;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(81, 73);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(235, 20);
            this.tbDescription.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(81, 51);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(235, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(81, 29);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(235, 20);
            this.tbCode.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Tipo de Cuenta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Número";
            // 
            // dgAccountantAccount
            // 
            this.dgAccountantAccount.AllowUserToAddRows = false;
            this.dgAccountantAccount.AllowUserToDeleteRows = false;
            this.dgAccountantAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccountantAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Names,
            this.Description,
            this.AccountType,
            this.Amount,
            this.IdAccountType,
            this.Id,
            this.Selection});
            this.dgAccountantAccount.Location = new System.Drawing.Point(2, 170);
            this.dgAccountantAccount.Name = "dgAccountantAccount";
            this.dgAccountantAccount.ReadOnly = true;
            this.dgAccountantAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccountantAccount.Size = new System.Drawing.Size(802, 207);
            this.dgAccountantAccount.TabIndex = 30;
            this.dgAccountantAccount.TabStop = false;
            this.dgAccountantAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccountantAccount_CellContentClick);
            // 
            // cbAccountType
            // 
            this.cbAccountType.DisplayMember = "Type";
            this.cbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Location = new System.Drawing.Point(432, 27);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(235, 21);
            this.cbAccountType.TabIndex = 4;
            this.cbAccountType.ValueMember = "Id";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(81, 3);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(31, 20);
            this.tbId.TabIndex = 60;
            this.tbId.TabStop = false;
            this.tbId.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(429, 79);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(35, 13);
            this.labelError.TabIndex = 61;
            this.labelError.Text = "label1";
            this.labelError.Visible = false;
            // 
            // codeError
            // 
            this.codeError.Image = global::ComandoRadioElectrico.WinForms.Properties.Resources.iconoAdvertencia;
            this.codeError.Location = new System.Drawing.Point(322, 31);
            this.codeError.Name = "codeError";
            this.codeError.Size = new System.Drawing.Size(18, 18);
            this.codeError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.codeError.TabIndex = 63;
            this.codeError.TabStop = false;
            this.codeError.Visible = false;
            // 
            // nameError
            // 
            this.nameError.Image = global::ComandoRadioElectrico.WinForms.Properties.Resources.iconoAdvertencia;
            this.nameError.Location = new System.Drawing.Point(322, 54);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(18, 18);
            this.nameError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nameError.TabIndex = 65;
            this.nameError.TabStop = false;
            this.nameError.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ComandoRadioElectrico.WinForms.Properties.Resources.iconoAdvertencia;
            this.pictureBox3.Location = new System.Drawing.Point(673, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 66;
            this.pictureBox3.TabStop = false;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Código";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Names
            // 
            this.Names.DataPropertyName = "Name";
            this.Names.HeaderText = "Nombre";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // AccountType
            // 
            this.AccountType.DataPropertyName = "AccountTypeType";
            this.AccountType.HeaderText = "Tipo cuenta";
            this.AccountType.Name = "AccountType";
            this.AccountType.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Saldo";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // IdAccountType
            // 
            this.IdAccountType.DataPropertyName = "AccountTypeId";
            this.IdAccountType.HeaderText = "IdTipoCuenta";
            this.IdAccountType.Name = "IdAccountType";
            this.IdAccountType.ReadOnly = true;
            this.IdAccountType.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Selection
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Seleccionar";
            this.Selection.DefaultCellStyle = dataGridViewCellStyle1;
            this.Selection.HeaderText = "";
            this.Selection.Name = "Selection";
            this.Selection.ReadOnly = true;
            this.Selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selection.Text = "";
            // 
            // PantallaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 381);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.codeError);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.cbAccountType);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgAccountantAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaCuentas";
            this.Text = "Sistema de Gestión - Comando Radioeléctrico / Cuentas Contables";
            this.Load += new System.EventHandler(this.PantallaCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountantAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgAccountantAccount;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox codeError;
        private System.Windows.Forms.PictureBox nameError;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewButtonColumn Selection;        

    }
}