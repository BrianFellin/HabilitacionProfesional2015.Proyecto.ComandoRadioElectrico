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

        public static FindEntityResultDTO<AccountantAccountDTO> Search(string pSearchText, int pPage)
        {
            FindEntityResultDTO<AccountantAccountDTO> mResult = iAccountantAccountSvc.FindAccountantAccount(new FindEntityDTO
            {
                QuickSearchText = pSearchText,
                RecordCount = 10,
                SkipRecordCount = pPage * 10,
                OrderByDirectionDescending = true               
            });

            return mResult;                
        }
    }
}
