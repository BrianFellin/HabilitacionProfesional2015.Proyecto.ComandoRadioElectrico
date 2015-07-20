using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Exceptions
{
    public class PartnerException: Exception
    {
        public PartnerException(string pMessage) : base(pMessage)
        {
        }
    }
}
