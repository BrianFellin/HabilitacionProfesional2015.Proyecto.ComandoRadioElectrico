using ComandoRadioElectrico.Core.DTO;
using System.Collections.Generic;
using ComandoRadioElectrico.Core.Services.Interfaces;
using ComandoRadioElectrico.Core.Services.Implementations;
using ComandoRadioElectrico.Core;

namespace ComandoRadioElectrico.WinForms.Facade
{
    public static class AccountTypeFacade 
    {
        private static IAccountTypeService iAccountTypeSvc = new AccountTypeService();
        public static IList<AccountTypeDTO> GetAll()
        {
            return iAccountTypeSvc.GetAll();
        }
    }
}
