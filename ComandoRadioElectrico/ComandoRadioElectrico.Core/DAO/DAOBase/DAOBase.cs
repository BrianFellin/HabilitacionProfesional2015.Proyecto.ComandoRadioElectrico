using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.DAO.DAOBase
{
    public class DAOBase<T> : IDAOBase<T> where T:class
    {
        public void Create(T pEntity)
        {
            var mHibernateConfiguration = new Configuration().Configure();
            var mSessionFactory = mHibernateConfiguration.BuildSessionFactory();
            var mSession = mSessionFactory.OpenSession();
            var mTx = mSession.BeginTransaction();
            mSession.Save(pEntity);
            mTx.Commit();
            mSession.Close();
        }

        public void Update(T pEntity)
        {
            var mHibernateConfiguration = new Configuration().Configure();
            var mSessionFactory = mHibernateConfiguration.BuildSessionFactory();
            var mSession = mSessionFactory.OpenSession();
            var tx = mSession.BeginTransaction();
            mSession.SaveOrUpdate(pEntity);
            tx.Commit();
            mSession.Close();
        }

        public void Delete(int pEntityId)
        {
            var mHibernateConfiguration = new Configuration().Configure();
            var mSessionFactory = mHibernateConfiguration.BuildSessionFactory();
            var mSession = mSessionFactory.OpenSession();
            var tx = mSession.BeginTransaction();
            T mEntity = mSession.Get<T>(pEntityId);
            mSession.Delete(mEntity);
            tx.Commit();
            mSession.Close();
        }

        public T GetById(int pEntityId)
        {
            var hibernateConfiguration = new Configuration().Configure();
            var sessionFactory = hibernateConfiguration.BuildSessionFactory();
            var mSession = sessionFactory.OpenSession();
            T mEntity = mSession.Get<T>(pEntityId);
            mSession.Close();
            return mEntity;
        }

        public IEnumerable<T> GetAll()
        {
            var mHibernateConfiguration = new Configuration().Configure();
            var mSessionFactory = mHibernateConfiguration.BuildSessionFactory();
            var mSession = mSessionFactory.OpenSession();
            IEnumerable<T> mList = mSession.QueryOver<T>().List();
            mSession.Close();
            return mList;
        }
    }
}
