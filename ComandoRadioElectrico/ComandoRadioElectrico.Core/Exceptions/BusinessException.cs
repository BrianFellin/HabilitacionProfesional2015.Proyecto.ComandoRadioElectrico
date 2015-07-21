using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Exceptions
{
    /// <summary>
    /// Excepcion que se produce cuando hay un error en la capa de negocio
    /// </summary>
    public class BusinessException : Exception
    {
        public BusinessException (string pMessage) : base(pMessage)
        {
        }

        public BusinessException(string pMessage, Exception pException)
            : base(pMessage, pException)
        {
        }
    }
                
}
