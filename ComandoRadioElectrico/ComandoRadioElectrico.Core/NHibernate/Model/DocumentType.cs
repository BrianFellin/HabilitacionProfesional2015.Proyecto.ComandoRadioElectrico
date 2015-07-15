using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core.NHibernate.Model
{
    /// <summary>
    /// Esta clase instancia un tipo de documeto (DNI, LC, LE).
    /// </summary>
    public class DocumentType
    {
        public virtual int Id { get; set; }
        public virtual string Type { get; set; }        
    }
}
