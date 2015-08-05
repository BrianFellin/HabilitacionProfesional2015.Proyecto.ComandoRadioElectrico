using ComandoRadioElectrico.Core.Services.Interfaces;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core.Services
{
    public class DataSession : IDataSession
    {        
        private Configuration iNHibernateConfiguration;
        private readonly ISessionFactory iSessionFactory;
        private ITransaction iTransaction;
        private ISession iSession;
        private bool iDisposed;

        public DataSession()
        {
            this.iNHibernateConfiguration = new Configuration().Configure();
            this.iSessionFactory = this.iNHibernateConfiguration.BuildSessionFactory();
            this.iDisposed = false;
            this.iSession = this.iSessionFactory.OpenSession();
        }

        public void Delete<T>(int pEntityId) where T : class
        {                         
            T mEntity = this.iSession.Get<T>(pEntityId);
            this.iSession.Delete(mEntity);                             
        }

        public T Get<T>(int pEntityId) where T : class
        {           
            T mEntity = this.iSession.Get<T>(pEntityId);                        
            return mEntity;
        }

        public IEnumerable<T> GetRepository<T>() where T : class
        {           
            IEnumerable<T> mList = this.iSession.QueryOver<T>().List();            
            return mList;      
        }

        public void BeginTransaction()
        {
            if (this.iTransaction == null)
            {
                this.iTransaction = this.iSession.BeginTransaction();
            }
        }

        public void Commit()
        {
            if (this.iTransaction != null)
            {
                this.iTransaction.Commit();
            }
        }

        public void RollBack()
        {
            if (this.iTransaction != null)
            {
                this.iTransaction.Rollback();
            }            
        }

        public IEnumerable<T> GetByCriteria<T>(params Func<dynamic, bool>[] pCriteria) where T : class
        {
            throw new NotImplementedException();
        }


        public int Save(object pObject)
        {          
            int mId = this.iSession.Save(pObject).GetHashCode();                     
            return mId;
        }

        public void SaveOrUpdate(object pObject)
        {           
            this.iSession.SaveOrUpdate(pObject);                        
        }

        protected virtual void Dispose(bool pDisposing)
        {
            if (!this.iDisposed)
            {
                if (pDisposing)
                {
                    if (this.iTransaction != null)
                    {
                        this.iTransaction.Dispose();
                    }
                    if (this.iSession != null)
                    {
                        this.iSession.Close();
                        this.iSession.Dispose();
                    }
                }
                this.iDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}
