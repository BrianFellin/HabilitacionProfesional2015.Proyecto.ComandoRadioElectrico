namespace ComandoRadioElectrico.WinForms.Views
{
    partial class pantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiosDeSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gestionDeCobradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiosDeSociosToolStripMenuItem,
            this.gestionDeCuentasToolStripMenuItem,
            this.gestionDeCobradoresToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // gestiosDeSociosToolStripMenuItem
            // 
            this.gestiosDeSociosToolStripMenuItem.Name = "gestiosDeSociosToolStripMenuItem";
            this.gestiosDeSociosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.gestiosDeSociosToolStripMenuItem.Text = "Gestion de Socios";
            this.gestiosDeSociosToolStripMenuItem.Click += new System.EventHandler(this.gestiosDeSociosToolStripMenuItem_Click);
            // 
            // gestionDeCuentasToolStripMenuItem
            // 
            this.gestionDeCuentasToolStripMenuItem.Name = "gestionDeCuentasToolStripMenuItem";
            this.gestionDeCuentasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.gestionDeCuentasToolStripMenuItem.Text = "Gestion de Cuentas";
            this.gestionDeCuentasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeCuentasToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gestionDeCobradoresToolStripMenuItem
            // 
            this.gestionDeCobradoresToolStripMenuItem.Name = "gestionDeCobradoresToolStripMenuItem";
            this.gestionDeCobradoresToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.gestionDeCobradoresToolStripMenuItem.Text = "Gestion de Cobradores";
            this.gestionDeCobradoresToolStripMenuItem.Click += new System.EventHandler(this.gestionDeCobradoresToolStripMenuItem_Click);
            // 
            // pantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pantallaPrincipal";
            this.Text = "Sistema de Gestión - Comando Radioeléctrico";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiosDeSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeCobradoresToolStripMenuItem;
    }
}

