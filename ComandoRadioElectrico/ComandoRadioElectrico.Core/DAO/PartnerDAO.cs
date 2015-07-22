using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.NHibernate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.DAO
{
    public class PartnerDAO : DAOBase<Partner>, IPartnerDAO
    {
        public override FindEntityResult<Partner> Find(FindEntityParams pFindParams)
        {
            throw new NotImplementedException();
        }
    }
}
