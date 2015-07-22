using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core.NHibernate.Model
{
    /// <summary>
    /// Esta clase instancia una cuota.
    /// </summary>
    public class Quota
    {
        public virtual int Id { get; set; }
        public virtual GeneratedPeriod Period { get; set; }
        public virtual float Amount { get; set; }
        public virtual Boolean IsPaid { get; set; }
        public virtual Partner Partner { get; set; }
    }

}
