using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.Model;
using System;

namespace ComandoRadioElectrico.Core.DAO
{
    public class AccountTypeDAO : DAOBase<AccountType>, IAccountTypeDAO
    {
        public override FindEntityResult<AccountType> Find(FindEntityParams pFindParams)
        {
            throw new NotImplementedException();
        }
    }
}
