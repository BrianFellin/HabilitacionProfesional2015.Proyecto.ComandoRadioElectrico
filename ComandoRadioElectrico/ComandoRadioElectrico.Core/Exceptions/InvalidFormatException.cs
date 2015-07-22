using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Exceptions
{
    /// <summary>
    /// Excepcion que se produce cuando los datos tienen un formato invalido
    /// </summary>
    public class InvalidFormatException : Exception
    {
        public InvalidFormatException(string pMessage)
            : base(pMessage)
        {
        }
    }    
}
