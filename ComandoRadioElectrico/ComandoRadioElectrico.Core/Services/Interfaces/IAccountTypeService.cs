using ComandoRadioElectrico.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Services.Interfaces
{
    public interface IAccountTypeService
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
        void CreateAccountType(AccountTypeDTO pAccountTypeToCreate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAccountTypeToUpdate"></param>
        /// <returns></returns>
        void UpdateAccountType(AccountTypeDTO pAccountTypeToUpdate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAccountTypeToDelete"></param>
        void DeleteAccountType(DeletedEntityDTO pAccountTypeToDelete);
    }
}
