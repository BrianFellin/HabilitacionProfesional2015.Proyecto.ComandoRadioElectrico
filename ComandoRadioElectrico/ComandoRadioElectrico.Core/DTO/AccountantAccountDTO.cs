using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.DTO
{
    public class AccountantAccountDTO
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public int AccountTypeId { get; set; }
        public string AccountTypeType { get; set; }   
        public float Amount { get; set; }    
    }
}
