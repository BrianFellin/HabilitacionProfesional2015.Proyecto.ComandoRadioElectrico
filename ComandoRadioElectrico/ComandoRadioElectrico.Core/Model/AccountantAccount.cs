using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core.Model
{
    /// <summary>
    /// Esta clase instancia una cuenta contable.
    /// </summary>
    public class AccountantAccount
    {
        public virtual int Id { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual AccountType AccountType { get; set; }
        public virtual float Amount { get; set; }            
    }
}
