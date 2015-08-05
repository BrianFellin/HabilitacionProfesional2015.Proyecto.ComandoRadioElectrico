using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.Model;
using ComandoRadioElectrico.Core.Services.Interfaces;
using NHibernate.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace ComandoRadioElectrico.Core.DAO
{
    public class AccountantAccountDAO : DAOBase<AccountantAccount>, IAccountantAccountDAO
    {
        public override FindEntityResult<AccountantAccount> Find(FindEntityParams pFindParams)
        {
            // obtenemos la sesion actual
            IDataSession mSession = this.GetSession();
            try
            {
                IEnumerable<AccountantAccount> mSectBaseQry = (from t in mSession.GetRepository<AccountantAccount>().OrderBy(m => m.Name) select t);

                IEnumerable<AccountantAccount> mSectFilteredQry = mSectBaseQry;

                if (pFindParams.QuickSearchText != string.Empty)
                    mSectFilteredQry = mSectBaseQry.Where(t => t.Code.Contains(pFindParams.QuickSearchText) ||
                                                           t.Name.Contains(pFindParams.QuickSearchText));


                int mTotalRecords = mSectFilteredQry.Count();

                IEnumerable<AccountantAccount> mAccounts = mSectFilteredQry
                            .Skip(pFindParams.SkipRecordCount)
                            .Take(pFindParams.RecordCount)
                            .OrderBy(m => m.Name)
                            .ToList();

                return new FindEntityResult<AccountantAccount>
                {
                    TotalRecords = mTotalRecords,
                    Result = mAccounts
                };
            }
            catch (GenericADOException ex)
            {                
                throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
            }
            finally
            {
                mSession.Dispose();
            }
        }   
    }
}
