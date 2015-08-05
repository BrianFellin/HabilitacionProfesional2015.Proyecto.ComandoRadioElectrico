using System;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core.Services.Interfaces
{
    public interface IDataSession : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void RollBack();
        int Save(object pObject);
        void SaveOrUpdate(object pObject);
        void Delete<T>(int pEntityId) where T : class;
        T Get<T>(int pEntityId) where T : class;        
        IEnumerable<T> GetRepository<T>() where T : class;
        IEnumerable<T> GetByCriteria<T>(params Func<dynamic,bool>[]pCriteria) where T: class;
       
    }
}
