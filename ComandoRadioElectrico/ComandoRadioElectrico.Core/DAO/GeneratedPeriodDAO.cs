using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.NHibernate.Model;
using NHibernate.Cfg;
using NHibernate.Exceptions;
using System;

namespace ComandoRadioElectrico.Core.DAO
{
    public class GeneratedPeriodDAO : DAOBase<GeneratedPeriod>, IGeneratedPeriodDAO
    {
       public override FindEntityResult<GeneratedPeriod> Find(FindEntityParams pFindParams)
       {
          throw new NotImplementedException();
       }
       public int CreatePeriod(GeneratedPeriod pGeneratedPeriod)
       {
           try
           {
               var mHibernateConfiguration = new Configuration().Configure();
               var mSessionFactory = mHibernateConfiguration.BuildSessionFactory();
               var mSession = mSessionFactory.OpenSession();
               var mTx = mSession.BeginTransaction();
               mSession.Save(pGeneratedPeriod);
               mTx.Commit();

               var mId = mSession.QueryOver<GeneratedPeriod>().Where(p => p.Month == pGeneratedPeriod.Month && p.Year == pGeneratedPeriod.Year).SingleOrDefault().Id;
               mSession.Close();
               return mId;
           }
           catch (GenericADOException ex)
           {
               throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
           }
       }
    }
}
