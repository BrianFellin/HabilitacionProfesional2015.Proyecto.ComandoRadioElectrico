using System;
using ComandoRadioElectrico.Core.DTO;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core.Servicios.Aplication.Interface
{
    public interface IAccountTypeManagementService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAccountTypeId"></param>
        /// <returns></returns>
        AccountTypeDTO GetAccountType(int pAccountTypeId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<AccountTypeDTO> GetAll();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAccountTypeToCreate"></param>
        /// <returns></returns>
        AccountTypeDTO CreateAccountType(AccountTypeDTO pAccountTypeToCreate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAccountTypeToUpdate"></param>
        /// <returns></returns>
        AccountTypeDTO UpdateAccountType(AccountTypeDTO pAccountTypeToUpdate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAccountTypeToDelete"></param>
        void DeleteAccountType(DeletedEntityDTO pAccountTypeToDelete);

    }
}
