using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Exceptions
{
    /// <summary>
    /// Excepcion que se produce cuando hay de acceso a la capa de datos
    /// </summary>
    public class DataBaseException : Exception
    {
        public DataBaseException (string pMessage) : base(pMessage)
        {
        }
    }
                
}
