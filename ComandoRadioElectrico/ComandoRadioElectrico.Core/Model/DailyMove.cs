using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core.Model
{
    /// <summary>
    /// Esta clase instancia un movimiento diario.
    /// </summary>
    public class DailyMove
    {
        public virtual int Id { get; set; }
        public virtual int Number { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual float Amount { get; set; }
        public virtual MoveType MoveType { get; set; }
        public virtual AccountantAccount AccountantAccount { get; set; }
        public virtual AccountingEntry AccountingEntry { get; set; }             
    }
}
