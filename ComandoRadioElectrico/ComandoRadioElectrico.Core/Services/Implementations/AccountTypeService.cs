using AutoMapper;
using ComandoRadioElectrico.Core.DAO;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Services.Implementations
{
    public class AccountTypeService : BaseService, IAccountTypeService
    {
        private IAccountTypeDAO iAccountTypeDAO;
        
        public AccountTypeService()
        {
            this.iAccountTypeDAO = this.Resolve<IAccountTypeDAO>();
        }

        AccountTypeDTO IAccountTypeService.GetAccountType(int pAccountTypeId)
        {
            return Mapper.Map<AccountTypeDTO>(this.iAccountTypeDAO.GetById(pAccountTypeId));
        }

        IList<AccountTypeDTO> IAccountTypeService.GetAll()
        {
            return Mapper.Map<IList<AccountTypeDTO>>(this.iAccountTypeDAO.GetAll());
        }

        public void CreateAccountType(AccountTypeDTO pAccountTypeToCreate)
        {
            throw new NotImplementedException();
        }

        public void UpdateAccountType(AccountTypeDTO pAccountTypeToUpdate)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccountType(DeletedEntityDTO pAccountTypeToDelete)
        {
            throw new NotImplementedException();
        }
    }
}
