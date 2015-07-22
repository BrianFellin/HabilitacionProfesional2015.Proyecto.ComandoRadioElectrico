using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.NHibernate.Model;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core.DAO
{
    public interface IQuotaDAO : IDAOBase<Quota>
    {
        IEnumerable<Quota> GetQuotasOfPartner(int pIdPartner);
    }
}
