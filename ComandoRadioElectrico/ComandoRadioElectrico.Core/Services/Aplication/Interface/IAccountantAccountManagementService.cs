using System;
using ComandoRadioElectrico.Core.DTO;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core.Servicios.Aplication.Interface
{
    public interface IAccountantAccountManagementService
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
        /// <returns></returns>
        AccountantAccountDTO CreateAccountantAccount(AccountantAccountDTO pAccountantAccountToCreate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAccountantAccountToUpdate"></param>
        /// <returns></returns>
        AccountantAccountDTO UpdateAccountantAccount(AccountantAccountDTO pAccountantAccountToUpdate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAccountantAccountToDelete"></param>
        void DeleteAccountantAccount(DeletedEntityDTO pAccountantAccountToDelete);

    }
}
