using ComandoRadioElectrico.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Services.Interfaces
{
    public interface IAccountantAccountService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAccountantAccountToCreate"></param>
        void CreateAccountantAccount(AccountantAccountDTO pAccountantAccountToCreate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAccountantAccountToUpdate"></param>
        void UpdateAccountantAccount(AccountantAccountDTO pAccountantAccountToUpdate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAccountantAccountToDelete"></param>
        void DeleteAccountantAccount(DeletedEntityDTO pAccountantAccountToDelete);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pCriteria"></param>
        /// <returns></returns>
        FindEntityResultDTO<AccountantAccountDTO> FindAccountantAccount(FindEntityDTO pCriteria);
    }
}
