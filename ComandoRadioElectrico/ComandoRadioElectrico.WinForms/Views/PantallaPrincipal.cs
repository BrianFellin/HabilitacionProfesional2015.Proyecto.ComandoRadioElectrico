using ComandoRadioElectrico.WinForms.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComandoRadioElectrico.WinForms.Views
{
    public partial class pantallaPrincipal : Form
    {
        public pantallaPrincipal()
        {
            InitializeComponent();
        }

        private void gestiosDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaSocios mPartnerView = new PantallaSocios();
            mPartnerView.ShowDialog();
        }

        private void gestionDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaCuentas mAccountView = new PantallaCuentas();
            mAccountView.ShowDialog();
        }

        private void gestionDeCobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaCobradores mOfficerView = new PantallaCobradores();
            mOfficerView.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuotaFacade.GenerateQuotas(Core.Utils.MonthPeriod.Septiembre, 2015);
        }      
    }
}
