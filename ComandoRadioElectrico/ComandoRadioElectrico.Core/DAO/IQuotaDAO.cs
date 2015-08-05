using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.Model;
using ComandoRadioElectrico.Core.Utils;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core.DAO
{
    public interface IQuotaDAO : IDAOBase<Quota>
    {
        void GenerateQuotas(MonthPeriod pMonth, int pYear);

    }
}
