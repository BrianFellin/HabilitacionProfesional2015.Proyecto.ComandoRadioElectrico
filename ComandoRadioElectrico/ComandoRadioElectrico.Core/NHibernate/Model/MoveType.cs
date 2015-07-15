using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core.NHibernate.Model
{
    /// <summary>
    /// Esta clase instancia un tipo de movimiento (Débito, crédito).
    /// </summary>
    public class MoveType
    {
        public virtual int Id { get; set; }
        public virtual string Type { get; set; }        
    }
}
