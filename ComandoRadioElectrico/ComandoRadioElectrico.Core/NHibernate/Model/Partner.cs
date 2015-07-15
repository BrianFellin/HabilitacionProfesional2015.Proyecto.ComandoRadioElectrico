using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core.NHibernate.Model
{
    /// <summary>
    /// Esta clase instancia un socio.
    /// </summary>
    public class Partner
    {
        public virtual int Id { get; set; }
        public virtual Person Person { get; set; }
        public virtual Officer Officer { get; set; }
        public virtual string Code { get; set; }
        public virtual string CollectDomicile { get; set; }
        public virtual string CollectDay { get; set; }
        public virtual DateTime StarDate { get; set; }
        public virtual DateTime FinishDate { get; set; }
        public virtual float ValueQuota { get; set; }              
    }
}
