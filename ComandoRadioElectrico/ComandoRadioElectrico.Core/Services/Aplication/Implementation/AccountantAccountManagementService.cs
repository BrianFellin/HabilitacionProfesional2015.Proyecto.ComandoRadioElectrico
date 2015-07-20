using AutoMapper;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.NHibernate.Model;
using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Services.Business.Interface;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;
using System.Collections.Generic;
using System.Linq; 

namespace ComandoRadioElectrico.Core.Servicios.Aplication.Implementation
{
    public class AccountantAccountManagementService : BaseService, IAccountantAccountManagementService
    {
        public AccountantAccountDTO GetAccountantAccount(int pAccountantAccountId)
        {             
            // obtencion del servicio de cuentas contables
            IAccountantAccountService mAccountantAccountService = this.Resolve<IAccountantAccountService>();            
            AccountantAccount mAccountantAccount = mAccountantAccountService.GetById(pAccountantAccountId);
            if (mAccountantAccount == null)
                throw new System.InvalidOperationException(string.Format("Cuenta contable no encontrada", pAccountantAccountId));

            return Mapper.Map<AccountantAccountDTO>(mAccountantAccount);
        }

        public AccountantAccountDTO CreateAccountantAccount(AccountantAccountDTO pAccountantAccountToCreate)
        {
            //Validamos los campos del parametro de entrada
            if (pAccountantAccountToCreate.Code == string.Empty
                || pAccountantAccountToCreate.Amount < 0
                || pAccountantAccountToCreate.Name == string.Empty
                || pAccountantAccountToCreate.AccountTypeId < 1)
                throw new DataFieldException("Campos de datos obligatorios estan vacios");

            // creamos el objeto cuenta contable
            AccountantAccount mNewAccountantAccount = Mapper.Map<AccountantAccountDTO, AccountantAccount>(pAccountantAccountToCreate);

            //Obtencion del servicio de tipo de cuentas contables
            IAccountTypeService mAccountTypeSvc = this.Resolve<IAccountTypeService>();

            mNewAccountantAccount.AccountType = mAccountTypeSvc.GetById(pAccountantAccountToCreate.AccountTypeId);

            // obtencion del servicio de cuentas contables
            IAccountantAccountService mAccountantAccountSvc = this.Resolve<IAccountantAccountService>();

            // persistimos la informacion 
            AccountantAccount mAccountantAccount = mAccountantAccountSvc.Create(mNewAccountantAccount);

            // adaptamos y devolvemos el resultado
            return Mapper.Map<AccountantAccount, AccountantAccountDTO>(mAccountantAccount);   
        }

        public AccountantAccountDTO UpdateAccountantAccount(AccountantAccountDTO pAccountantAccountToUpdate)
        {
            // validamos parametro de entrada
            if (pAccountantAccountToUpdate == null) throw new System.ArgumentNullException("pAccountantAccountToUpdate");
            
            //Validamos los campos del parametro de entrada
            if (pAccountantAccountToUpdate.Code == string.Empty
                || pAccountantAccountToUpdate.Amount < 0
                || pAccountantAccountToUpdate.Name == string.Empty
                || pAccountantAccountToUpdate.AccountTypeId < 1)
                throw new DataFieldException("Campos de datos obligatorios estan vacios");
            
            // obtencion del servicio de cuentas contables 
            IAccountantAccountService mAccountantAccountSvc = new AccountantAccountService(); 

            // obtenemos el objeto a modificar
            AccountantAccount mAccountantAccountToUpdate = mAccountantAccountSvc.GetById(pAccountantAccountToUpdate.Id);

            // validamos que se haya encontrado la cuenta contable
            if (mAccountantAccountToUpdate == null) throw new System.InvalidOperationException(string.Format("Cuenta contable no encontrada", pAccountantAccountToUpdate.Id));

            //Se valida que el saldo de la cuenta no cambio, ya que no se puede modificar
            if (mAccountantAccountToUpdate.Amount != pAccountantAccountToUpdate.Amount) throw new AccountantAccountException(string.Format("El saldo de la cuenta no se puede modificar", pAccountantAccountToUpdate.Id));

            //validamos que no halla cambiado el tipo de cuenta contable, de lo contrario
            //se establece el cambio
            if (pAccountantAccountToUpdate.AccountTypeId != mAccountantAccountToUpdate.AccountType.Id)
            {
                // obtenemos el tipo de cuenta contable
                IAccountTypeService mAccountTypeSvc = this.Resolve<IAccountTypeService>();
                mAccountantAccountToUpdate.AccountType = mAccountTypeSvc.GetById(pAccountantAccountToUpdate.AccountTypeId);
            }
            Mapper.Map<AccountantAccountDTO, AccountantAccount>(pAccountantAccountToUpdate, mAccountantAccountToUpdate);

            // actualizamos la entidad
            mAccountantAccountSvc.Update(mAccountantAccountToUpdate);

            return Mapper.Map<AccountantAccountDTO>(mAccountantAccountToUpdate);
        }

        public void DeleteAccountantAccount(DeletedEntityDTO pAccountantAccountToDelete)
        {
            //validamos que el Id este en el rango correcto
            if (pAccountantAccountToDelete.Id < -1) throw new System.ArgumentOutOfRangeException("pAccountantAccountToDelete");
          
            // obtencion del servicio de cuentas contables
            IAccountantAccountService mAccountantAccountSvc = this.Resolve<IAccountantAccountService>(); 

            // eliminamos la cuenta contable
            mAccountantAccountSvc.Delete(pAccountantAccountToDelete.Id);
        }

        public IList<AccountantAccountDTO> GetAll()
        {
            // obtencion del servicio de cuentas contables 
            IAccountantAccountService mAccountantAccountSvc = this.Resolve<IAccountantAccountService>();

            //devuelvo todas las instancias
           return Mapper.Map<IList<AccountantAccount>,IList<AccountantAccountDTO>>(mAccountantAccountSvc.GetAll().ToList());            
        }      
    }
}
