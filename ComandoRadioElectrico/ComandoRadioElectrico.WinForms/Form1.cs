using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComandoRadioElectrico.Core.NHibernate.Model;
using ComandoRadioElectrico.Core;

namespace ComandoRadioElectrico.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person persona = new Person
            {
                FirstName= textBox1.Text,
                LastName = textBox2.Text,
                DocumentNumber = textBox4.Text,
                Domicile = textBox5.Text,
                Telephone = textBox6.Text
            };
            NH.AgregarPersona(persona);
        }
    }
}
