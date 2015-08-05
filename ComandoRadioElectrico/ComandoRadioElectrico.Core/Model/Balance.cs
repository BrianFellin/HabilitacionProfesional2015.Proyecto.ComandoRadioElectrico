using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core.Model
{
    /// <summary>
    /// Esta clase instancia un Balance.
    /// </summary>
    public class Balance
    {
        public virtual int Id { get; set; }
        public virtual DateTime DateFrom { get; set; }
        public virtual DateTime DateUntil { get; set; }
        public virtual DateTime DateOfRealization { get; set; }
        public virtual string Description { get; set; }        
    }
}
