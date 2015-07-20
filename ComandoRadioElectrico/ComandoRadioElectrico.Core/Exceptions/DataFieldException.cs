using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Exceptions
{
    /// <summary>
    /// Excepcion que se produce cuando hay de acceso a la capa de datos
    /// </summary>
    public class DataFieldException : Exception
    {
        public DataFieldException (string pMessage) : base(pMessage)
        {
        }
    }
                
}
