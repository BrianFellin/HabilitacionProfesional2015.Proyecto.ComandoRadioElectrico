using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core.Model
{
    /// <summary>
    /// Esta clase instancia un tipo de cuenta (activo, pasivo, patrimonio, ingreso y gasto).
    /// </summary>
    public class AccountType
    {
        public virtual int Id { get; set; }
        public virtual string Type { get; set; }        
    }
}
