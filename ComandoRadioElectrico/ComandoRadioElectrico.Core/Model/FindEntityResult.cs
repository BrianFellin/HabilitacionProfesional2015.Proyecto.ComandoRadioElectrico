using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Model
{
        public class FindEntityResult<T>
        {
            public int TotalRecords { get; set; }
            public IEnumerable<T> Result { get; set; }
        }    
}
