using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.DTO
{
    public class FindEntityResultDTO<T>
    {
        public int TotalRecords { get; set; }
        public IEnumerable<T> Result { get; set; }
    }
}
