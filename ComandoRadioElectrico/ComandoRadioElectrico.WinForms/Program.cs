﻿using ComandoRadioElectrico.Core;
using ComandoRadioElectrico.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComandoRadioElectrico.WinForms.Views;

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

