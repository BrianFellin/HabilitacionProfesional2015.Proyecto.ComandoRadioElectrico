using ComandoRadioElectrico.Core;
using System;
using System.Windows.Forms;

namespace ComandoRadioElectrico.WinForms.Views
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Inicializo el Core
            CoreServerModuleImpl.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new pantallaPrincipal());
            
    
        }
    }
}

