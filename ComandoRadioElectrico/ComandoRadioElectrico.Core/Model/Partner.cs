using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core.Model
{
    /// <summary>
    /// Esta clase instancia un socio.
    /// </summary>
    public class Partner
    {        
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual string DocumentNumber { get; set; }
        public virtual string Domicile { get; set; }
        public virtual string Telephone { get; set; }        
        public virtual Officer Officer { get; set; }        
        public virtual string CollectDomicile { get; set; }
        public virtual string CollectDay { get; set; }
        public virtual DateTime? StarDate { get; set; }
        public virtual DateTime? FinishDate { get; set; }
        public virtual float ValueQuota { get; set; }
        public virtual int QuotaRegime { get; set; }
        public virtual int QuotaCounter { get; set; }
    }
}
