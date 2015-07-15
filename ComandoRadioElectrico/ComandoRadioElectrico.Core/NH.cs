using ComandoRadioElectrico.Core.NHibernate.Model;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core
{
    public static class NH
    {
        public static void AgregarPersona(Person pPersona)
        {
            
            var hibernateConfiguration = new Configuration().Configure();
            var sessionFactory = hibernateConfiguration.BuildSessionFactory();
            var session = sessionFactory.OpenSession();
            pPersona.DocumentType = session.Get<DocumentType>(1);
            var tx = session.BeginTransaction();
            session.Save(pPersona);
            tx.Commit();
            session.Close();
        }
    }
}
