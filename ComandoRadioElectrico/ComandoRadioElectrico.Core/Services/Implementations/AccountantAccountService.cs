using ComandoRadioElectrico.Core.Services.Interfaces;
using System.Collections.Generic;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.DAO;
using AutoMapper;
using ComandoRadioElectrico.Core.Model;
using ComandoRadioElectrico.Core.Exceptions;
using System.Linq;

namespace ComandoRadioElectrico.Core.Services.Implementations
{
    public class AccountantAccountService : BaseService, IAccountantAccountService
    {
        private IAccountantAccountDAO iAccountantAccountDAO;
        private IAccountTypeDAO iAccountTypeDAO;
        
        public AccountantAccountService()
        {
            this.iAccountantAccountDAO = this.Resolve<IAccountantAccountDAO>();
            this.iAccountTypeDAO = this.Resolve<IAccountTypeDAO>();
        }       

        public void CreateAccountantAccount(AccountantAccountDTO pAccountantAccountToCreate)
        {
           //Validamos los campos del parametro de entrada
           if (pAccountantAccountToCreate.Code == string.Empty
                || pAccountantAccountToCreate.Amount < 0
                || pAccountantAccountToCreate.Name == string.Empty
                || pAccountantAccountToCreate.AccountTypeId < 1)
                throw new BusinessException("Campos de datos obligatorios estan vacios");

            // creamos el objeto cuenta contable
            AccountantAccount mNewAccountantAccount = Mapper.Map<AccountantAccountDTO, AccountantAccount>(pAccountantAccountToCreate);
            
            //Obtenemos el tipo de cuenta de la cuenta contable
            mNewAccountantAccount.AccountType = this.iAccountTypeDAO.GetById(pAccountantAccountToCreate.AccountTypeId);

            //validamos que el codigo sea unico y no halla otra cuenta con el mismo codigo
            if ((from a in this.iAccountantAccountDAO.GetAll() where a.Code == pAccountantAccountToCreate.Code select a).Count() > 0)
            {
                throw new BusinessException("Ya existe una cuenta con el codigo ingresado, ingrese otro");
            }
            
            // persistimos la informacion 
            this.iAccountantAccountDAO.Create(mNewAccountantAccount); 
        }

        public void UpdateAccountantAccount(AccountantAccountDTO pAccountantAccountToUpdate)
        {
           //validamos parametro de entrada
           if (pAccountantAccountToUpdate == null) throw new System.ArgumentNullException("pAccountantAccountToUpdate");

           //Validamos los campos del parametro de entrada
           if (pAccountantAccountToUpdate.Code == string.Empty
               || pAccountantAccountToUpdate.Amount < 0
               || pAccountantAccountToUpdate.Name == string.Empty
               || pAccountantAccountToUpdate.AccountTypeId < 1)
               throw new BusinessException("Campos de datos obligatorios estan vacios");

           // obtenemos el objeto a modificar
           AccountantAccount mAccountantAccountToUpdate = this.iAccountantAccountDAO.GetById(pAccountantAccountToUpdate.Id);

           // validamos que se haya encontrado la cuenta contable
           if (mAccountantAccountToUpdate == null) throw new System.InvalidOperationException(string.Format("Cuenta contable no encontrada", pAccountantAccountToUpdate.Id));

           //Se valida que el saldo de la cuenta no cambio, ya que no se puede modificar
           if (mAccountantAccountToUpdate.Amount != pAccountantAccountToUpdate.Amount) throw new BusinessException(string.Format("El saldo de la cuenta no se puede modificar", pAccountantAccountToUpdate.Id));

            //validamos que no halla cambiado el tipo de cuenta contable, de lo contrario
            //se establece el cambio
            if (pAccountantAccountToUpdate.AccountTypeId != mAccountantAccountToUpdate.AccountType.Id)
            {
               mAccountantAccountToUpdate.AccountType = this.iAccountTypeDAO.GetById(pAccountantAccountToUpdate.AccountTypeId);
            }
            //validamos que el codigo sea unico y no halla otra cuenta con el mismo codigo
            if ((from a in this.iAccountantAccountDAO.GetAll() where a.Code == pAccountantAccountToUpdate.Code & a.Id != pAccountantAccountToUpdate.Id select a).Count() > 0)
            {
                throw new BusinessException("Ya existe una cuenta con el codigo ingresado, ingrese otro");
            }

            Mapper.Map<AccountantAccountDTO, AccountantAccount>(pAccountantAccountToUpdate, mAccountantAccountToUpdate);

            // actualizamos la entidad
            this.iAccountantAccountDAO.Update(mAccountantAccountToUpdate);
        }

        public void DeleteAccountantAccount(DeletedEntityDTO pAccountantAccountToDelete)
        {
          //validamos que el Id este en el rango correcto
          if (pAccountantAccountToDelete.Id < -1) throw new System.ArgumentOutOfRangeException("pAccountantAccountToDelete");

          // eliminamos la cuenta contable
          this.iAccountantAccountDAO.Delete(pAccountantAccountToDelete.Id);
        }

        public FindEntityResultDTO<AccountantAccountDTO> FindAccountantAccount(FindEntityDTO pCriteria)
        {
            return Mapper.Map<FindEntityResult<AccountantAccount>,FindEntityResultDTO<AccountantAccountDTO>>(this.iAccountantAccountDAO.Find(new FindEntityParams
            {
                QuickSearchText = pCriteria.QuickSearchText,
                RecordCount = pCriteria.RecordCount,
                OrderByDirectionDescending = pCriteria.OrderByDirectionDescending,
                SkipRecordCount = pCriteria.SkipRecordCount
            }));            
        }
    }
}
