using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.WinForms.Adapter
{
    /// <summary>
    /// Clase que tiene parte de los datos de un Partner(socio)
    /// </summary>
    class PartnerGridViewAdapter
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Domicile { get; set; }
        public string Document { get; set; }
    }
}
