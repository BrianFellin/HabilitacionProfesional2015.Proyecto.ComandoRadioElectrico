using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;
using System.Collections.Generic;

namespace ComandoRadioElectrico.WinForms.Facade
{
    public class AccountTypeService : BaseService
    {
        private static AccountTypeService iAccountType;

        private AccountTypeService()
        {
            
        }
        public static AccountTypeService GetInstance
        {
            get
            {
                if (iAccountType == null)
                {
                    iAccountType = new AccountTypeService();
                }
                return iAccountType;
            }
        }        
        public IList<AccountTypeDTO> GetAll()
        {
            IAccountTypeManagementService mAccountTypeSvc = this.Resolve<IAccountTypeManagementService>();
            return mAccountTypeSvc.GetAll();
        }
    }
}
