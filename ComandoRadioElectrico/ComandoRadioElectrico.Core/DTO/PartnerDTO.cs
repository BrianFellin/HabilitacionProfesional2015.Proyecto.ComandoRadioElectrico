using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.DTO
{
    public class PartnerDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentTypeType { get; set; }
        public string DocumentNumber { get; set; }
        public string Domicile { get; set; }
        public string Telephone { get; set; }
        public OfficerDTO Officer { get; set; }
        public string CollectDomicile { get; set; }
        public string CollectDay { get; set; }
        public int QuotaRegime { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public float ValueQuota { get; set; } 
    }
}
