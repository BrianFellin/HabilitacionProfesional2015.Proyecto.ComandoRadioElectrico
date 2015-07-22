using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.DTO
{
    public class FindEntityDTO
    {
        public FindEntityDTO()
        {
           this.Filters = new System.Collections.Specialized.NameValueCollection();
        }

        public int SkipRecordCount { get; set; }
        public int RecordCount { get; set; }
        public string QuickSearchText { get; set; }
        public string OrderBy { get; set; }
        public bool OrderByDirectionDescending { get; set; }
        public System.Collections.Specialized.NameValueCollection Filters { get; set; }        
    }
}
