using ComandoRadioElectrico.Core.Exceptions;
using NHibernate.Cfg;
using NHibernate.Exceptions;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core.DAO.DAOBase
{
    public class DAOBase<T> : IDAOBase<T> where T:class
    {
        public void Create(T pEntity)
        {
            try
            {
                var mHibernateConfiguration = new Configuration().Configure();
                var mSessionFactory = mHibernateConfiguration.BuildSessionFactory();
                var mSession = mSessionFactory.OpenSession();
                var mTx = mSession.BeginTransaction();
                mSession.Save(pEntity);
                mTx.Commit();
                mSession.Close();
            }
            catch (GenericADOException ex)
            {
                throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
            }
            
        }

        public void Update(T pEntity)
        {
            try
            {
                var mHibernateConfiguration = new Configuration().Configure();
                var mSessionFactory = mHibernateConfiguration.BuildSessionFactory();
                var mSession = mSessionFactory.OpenSession();
                var tx = mSession.BeginTransaction();
                mSession.SaveOrUpdate(pEntity);
                tx.Commit();
                mSession.Close();
            }
            catch (GenericADOException ex)
            {
                throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
            }
        }

        public void Delete(int pEntityId)
        {
            try
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
            catch (GenericADOException ex)
            {
                throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
            }
        }

        public T GetById(int pEntityId)
        {
            try
            {
                var hibernateConfiguration = new Configuration().Configure();
                var sessionFactory = hibernateConfiguration.BuildSessionFactory();
                var mSession = sessionFactory.OpenSession();
                T mEntity = mSession.Get<T>(pEntityId);
                mSession.Close();
                return mEntity;
            }
            catch (GenericADOException ex)
            {
                throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                var mHibernateConfiguration = new Configuration().Configure();
                var mSessionFactory = mHibernateConfiguration.BuildSessionFactory();
                var mSession = mSessionFactory.OpenSession();
                IEnumerable<T> mList = mSession.QueryOver<T>().List();
                mSession.Close();
                return mList;
            }
            catch (GenericADOException ex)
            {
                throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
            }
        }
    }
}
