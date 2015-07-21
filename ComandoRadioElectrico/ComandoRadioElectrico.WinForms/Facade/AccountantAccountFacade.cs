using ComandoRadioElectrico.Core;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Services.Implementations;
using ComandoRadioElectrico.Core.Services.Interfaces;
using System.Collections.Generic;

namespace ComandoRadioElectrico.WinForms.Facade
{
    public static class AccountantAccountFacade 
    {
        private static IAccountantAccountService iAccountantAccountSvc = new AccountantAccountService();
        public static void CreateAccountantAccount(AccountantAccountDTO pAccountantAccount)
        {
           iAccountantAccountSvc.CreateAccountantAccount(pAccountantAccount);            
        }

        public static void UpdateAccountantAccount(AccountantAccountDTO pAccountantAccount)
        {
            iAccountantAccountSvc.UpdateAccountantAccount(pAccountantAccount);
        }

        public static void DeleteAccountantAccount(DeletedEntityDTO pDeletedEntityDTO)
        {
            iAccountantAccountSvc.DeleteAccountantAccount(pDeletedEntityDTO);
        }

        public static IList<AccountantAccountDTO> GetAll()
        {
            return iAccountantAccountSvc.GetAll();
        }
    }
}
