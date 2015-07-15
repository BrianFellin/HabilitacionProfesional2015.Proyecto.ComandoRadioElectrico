using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core.NHibernate.Model
{
    /// <summary>
    /// Esta clase instancia una persona.
    /// </summary>
    public class Person
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual string DocumentNumber { get; set; }
        public virtual string Domicile { get; set; }
        public virtual string Telephone { get; set; }
    }
}
