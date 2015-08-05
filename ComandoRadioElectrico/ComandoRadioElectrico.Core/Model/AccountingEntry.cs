using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core.Model
{
    /// <summary>
    /// Esta clase instancia un asiento contable.
    /// </summary>
    public class AccountingEntry
    {
        public virtual int Id { get; set; }
        public virtual string Code { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string Description { get; set; }
        public virtual Balance Balance { get; set; }        
    }
}
