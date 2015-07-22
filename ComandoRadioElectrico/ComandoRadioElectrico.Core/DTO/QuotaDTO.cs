using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.DTO
{
    public class QuotaDTO
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public float Amount { get; set; }
        public Boolean IsPaid { get; set; }
        public int IdPartner { get; set; }
    }
}
