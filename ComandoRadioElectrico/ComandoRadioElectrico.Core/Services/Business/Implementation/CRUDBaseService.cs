using ComandoRadioElectrico.Core.Servicios.Business.Interface;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core.Servicios.Business.Implementation
{
    public abstract class CRUDBaseService<T> : ICRUDBase<T> where T :class
    {
        public virtual T Create(T pEntity)
        {          
            var hibernateConfiguration = new Configuration().Configure();
            var sessionFactory = hibernateConfiguration.BuildSessionFactory();
            var session = sessionFactory.OpenSession();
            var tx = session.BeginTransaction();
            session.Save(pEntity);
            tx.Commit();
            session.Close();
            return pEntity;
        }

        public virtual void Update(T pEntity)
        {
            var hibernateConfiguration = new Configuration().Configure();
            var sessionFactory = hibernateConfiguration.BuildSessionFactory();
            var session = sessionFactory.OpenSession();
            var tx = session.BeginTransaction();
            session.SaveOrUpdate(pEntity);
            tx.Commit();
            session.Close();
        }

        public virtual void Delete(int pEntityId)
        {            
            var hibernateConfiguration = new Configuration().Configure();
            var sessionFactory = hibernateConfiguration.BuildSessionFactory();
            var session = sessionFactory.OpenSession();
            var tx = session.BeginTransaction();
            session.Delete(pEntityId);
            tx.Commit();
            session.Close();
        }

        public T GetById(int pEntityId)
        {
            var hibernateConfiguration = new Configuration().Configure();
            var sessionFactory = hibernateConfiguration.BuildSessionFactory();
            var mSession = sessionFactory.OpenSession();
            return mSession.Get<T>(pEntityId);                                
        }

        public IEnumerable<T> GetAll()
        {
            var hibernateConfiguration = new Configuration().Configure();
            var sessionFactory = hibernateConfiguration.BuildSessionFactory();
            var mSession = sessionFactory.OpenSession();
            var a = mSession.QueryOver<T>().List();
            return a;
        }

    }
}

