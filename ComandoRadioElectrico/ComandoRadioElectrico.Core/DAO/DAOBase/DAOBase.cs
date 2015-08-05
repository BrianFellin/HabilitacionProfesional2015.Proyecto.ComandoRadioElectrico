using ComandoRadioElectrico.Core.Exceptions;
using NHibernate.Exceptions;
using System.Collections.Generic;
using ComandoRadioElectrico.Core.Model;
using ComandoRadioElectrico.Core.Services.Implementations;
using ComandoRadioElectrico.Core.Services.Interfaces;

namespace ComandoRadioElectrico.Core.DAO.DAOBase
{
    public abstract class DAOBase<T> : BaseService, IDAOBase<T> where T:class
    {    
        public int Create(T pEntity)
        {
            // sesion de datos actual
            IDataSession mSession = this.GetSession();
            try
            {                
                mSession.BeginTransaction();
                // persistimos los datos
                int mId = mSession.Save(pEntity);
                mSession.Commit();
                return mId;
            }
            catch (GenericADOException ex)
            {
                mSession.RollBack();
                throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
            }      
            finally
            {
                mSession.Dispose();
            }
        }

        public void Update(T pEntity)
        {
            // sesion de datos actual
            IDataSession mSession = this.GetSession();
            try
            {
                mSession.BeginTransaction();
                // persistimos los datos
                mSession.SaveOrUpdate(pEntity);
                mSession.Commit();
            }
            catch (GenericADOException ex)
            {
                mSession.RollBack();
                throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
            }
            finally
            {
                mSession.Dispose();
            }
        }

        public void Delete(int pEntityId)
        {
            // sesion de datos actual
            IDataSession mSession = this.GetSession();
            try
            {

                mSession.BeginTransaction();
                // eliminamos la entidad
                mSession.Delete<T>(pEntityId);
                mSession.Commit();
            }
            catch (GenericADOException ex)
            {
                mSession.RollBack();
                throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
            }
        }

        public T GetById(int pEntityId)
        {
            // sesion de datos actual
            IDataSession mSession = this.GetSession();
            try
            {                
                return mSession.Get<T>(pEntityId);
            }
            catch (GenericADOException ex)
            {
                throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
            }
            finally
            {
                mSession.Dispose();
            }
        }

        public IEnumerable<T> GetAll()
        {
            // sesion de datos actual
            IDataSession mSession = this.GetSession();
            try
            {                
                return mSession.GetRepository<T>();                
            }
            catch (GenericADOException ex)
            {
                throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
            }
            finally
            {
                mSession.Dispose();
            }
        }

        public abstract FindEntityResult<T> Find(FindEntityParams pFindParams);                        
    }
}
