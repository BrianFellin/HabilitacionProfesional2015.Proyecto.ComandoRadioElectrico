using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.DTO
{
    public class PartnerDTO
    {
        public int Id { get; set; }
        public PersonDTO Person { get; set; }
        public OfficerDTO Officer { get; set; }
        public string Code { get; set; }
        public string CollectDomicile { get; set; }
        public DateTime CollectDay { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime FinishDate { get; set; }
        public  double ValueQuota { get; set; } 
    }
}
