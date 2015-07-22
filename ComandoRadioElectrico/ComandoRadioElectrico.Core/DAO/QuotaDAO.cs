using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.NHibernate.Model;
using ComandoRadioElectrico.Core.Utils;
using NHibernate.Cfg;
using NHibernate.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComandoRadioElectrico.Core.DAO
{
    public class QuotaDAO : DAOBase<Quota>, IQuotaDAO 
    {
        public override FindEntityResult<Quota> Find(FindEntityParams pFindParams)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Quota> GetQuotasOfPartner(int pIdPartner)
        {
            try
            {
                var hibernateConfiguration = new Configuration().Configure();
                var sessionFactory = hibernateConfiguration.BuildSessionFactory();
                var mSession = sessionFactory.OpenSession();
                return mSession.QueryOver<Quota>().Where(p => p.Partner.Id == pIdPartner).List();              
            }
            catch (GenericADOException ex)
            {
                throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
            }
        }
    }
}
