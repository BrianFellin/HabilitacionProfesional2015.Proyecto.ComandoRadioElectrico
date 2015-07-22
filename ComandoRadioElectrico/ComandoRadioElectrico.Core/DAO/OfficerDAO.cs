using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.NHibernate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.DAO
{
    public class OfficerDAO : DAOBase<Officer>, IOfficerDAO
    {
        public override FindEntityResult<Officer> Find(FindEntityParams pFindParams)
        {
            throw new NotImplementedException();
        }
    }
}
