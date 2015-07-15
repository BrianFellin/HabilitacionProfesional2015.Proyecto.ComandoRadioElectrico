using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core.NHibernate.Model
{
    /// <summary>
    /// Esta clase instancia un Cobrador.
    /// </summary>
    public class Officer
    {
        public virtual int Id { get; set; }
        public virtual Person Person { get; set; }
        public virtual string Code { get; set; }
        public virtual DateTime StarDate { get; set; }
        public virtual DateTime FinishDate { get; set; }        
    }
}
