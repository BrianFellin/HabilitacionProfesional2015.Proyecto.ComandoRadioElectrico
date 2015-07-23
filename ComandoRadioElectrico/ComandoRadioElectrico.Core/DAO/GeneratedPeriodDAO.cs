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
    }
}
