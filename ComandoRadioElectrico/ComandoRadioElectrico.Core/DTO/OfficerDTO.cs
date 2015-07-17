using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.DTO
{
    public class OfficerDTO
    {
        public virtual int Id { get; set; }
        public virtual PersonDTO Person { get; set; }
        public virtual string Code { get; set; }
        public virtual DateTime StarDate { get; set; }
        public virtual DateTime FinishDate { get; set; }
    }
}
