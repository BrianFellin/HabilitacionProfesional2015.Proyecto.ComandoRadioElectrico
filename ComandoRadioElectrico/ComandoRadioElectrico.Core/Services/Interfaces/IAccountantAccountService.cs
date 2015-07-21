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
        /// <param name="pAccountantAccountId"></param>
        /// <returns></returns>
        AccountantAccountDTO GetAccountantAccount(int pAccountantAccountId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<AccountantAccountDTO> GetAll();

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
    }
}
