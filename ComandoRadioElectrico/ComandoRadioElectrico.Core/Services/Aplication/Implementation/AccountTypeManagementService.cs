using AutoMapper;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.NHibernate.Model;
using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Services.Business.Interface;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;
using System.Collections.Generic;
using System.Linq; 

namespace ComandoRadioElectrico.Core.Servicios.Aplication.Implementation
{
    public class AccountTypeManagementService : BaseService, IAccountTypeManagementService
    {
        public AccountTypeDTO GetAccountType(int pAccountTypeId)
        {             
            // obtencion del servicio de tipo de cuentas
            IAccountTypeService mAccountTypeService = this.Resolve<IAccountTypeService>();            
            AccountType mAccountType = mAccountTypeService.GetById(pAccountTypeId);
            if (mAccountType == null)
                throw new System.InvalidOperationException(string.Format("Tipo de cuenta no encontrada", pAccountTypeId));

            return Mapper.Map<AccountTypeDTO>(mAccountType);
        }

        public IList<AccountTypeDTO> GetAll()
        {
            // obtencion del servicio de cuentas contables 
            IAccountTypeService mAccountTypeSvc = this.Resolve<IAccountTypeService>();

            //devuelvo todas las instancias
            return Mapper.Map<IList<AccountType>,IList<AccountTypeDTO>>(mAccountTypeSvc.GetAll().ToList());            
        }


        public AccountTypeDTO CreateAccountType(AccountTypeDTO pAccountTypeToCreate)
        {
            throw new System.NotImplementedException();
        }

        public AccountTypeDTO UpdateAccountType(AccountTypeDTO pAccountTypeToUpdate)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAccountType(DeletedEntityDTO pAccountTypeToDelete)
        {
            throw new System.NotImplementedException();
        }
    }
}
