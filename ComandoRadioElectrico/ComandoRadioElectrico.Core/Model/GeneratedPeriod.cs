using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core.Model
{
    /// <summary>
    /// Esta clase instancia un periodo generado que contiene cuotas.
    /// </summary>
    public class GeneratedPeriod
    {
        public virtual int Id { get; set; }
        public virtual string Month { get; set; }
        public virtual int Year { get; set; }
        
    }

}
