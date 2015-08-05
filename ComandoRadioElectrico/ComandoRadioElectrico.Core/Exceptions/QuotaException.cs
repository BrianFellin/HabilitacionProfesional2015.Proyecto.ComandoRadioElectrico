using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Exceptions
{
    public class QuotaException : Exception
    {
        public QuotaException(string pMessage)
            : base(pMessage)
        {
        }
    }
}
