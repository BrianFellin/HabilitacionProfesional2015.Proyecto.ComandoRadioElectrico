using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;
using System.Collections.Generic;

namespace ComandoRadioElectrico.WinForms.Facade
{
    public class AccountantAccountService : BaseService
    {
        private static AccountantAccountService iAccountantAccount;

        private AccountantAccountService()
        {
            
        }
        public static AccountantAccountService GetInstance
        {
            get
            {
                if (iAccountantAccount == null)
                {
                    iAccountantAccount = new AccountantAccountService();
                }
                return iAccountantAccount;
            }
        }
        public void CreateAccountantAccount(AccountantAccountDTO pAccountantAccount)
        {
            IAccountantAccountManagementService mAccountantAccountSvc = this.Resolve<IAccountantAccountManagementService>();
            mAccountantAccountSvc.CreateAccountantAccount(pAccountantAccount);
        }

        public void UpdateAccountantAccount(AccountantAccountDTO pAccountantAccount)
        {
            IAccountantAccountManagementService mAccountantAccountSvc = this.Resolve<IAccountantAccountManagementService>();
            mAccountantAccountSvc.UpdateAccountantAccount(pAccountantAccount);
        }

        public void DeleteAccountantAccount(DeletedEntityDTO pDeletedEntityDTO)
        {
            IAccountantAccountManagementService mAccountantAccountSvc = this.Resolve<IAccountantAccountManagementService>();
            mAccountantAccountSvc.DeleteAccountantAccount(pDeletedEntityDTO);
        }

        public IList<AccountantAccountDTO> GetAll()
        {
            IAccountantAccountManagementService mAccountantAccountSvc = this.Resolve<IAccountantAccountManagementService>();
            return mAccountantAccountSvc.GetAll();
        }
    }
}
