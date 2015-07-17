using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Exceptions
{
    /// <summary>
    /// Excepcion que se produce cuando hay un error en una cuenta contable
    /// </summary>
    public class AccountantAccountException : Exception
    {
        public AccountantAccountException (string pMessage) : base(pMessage)
        {
        }
    }
                
}
