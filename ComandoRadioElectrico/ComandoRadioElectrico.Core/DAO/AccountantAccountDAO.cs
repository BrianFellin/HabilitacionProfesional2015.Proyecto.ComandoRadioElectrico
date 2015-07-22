using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.NHibernate.Model;
using System.Collections.Generic;
using System.Linq;

namespace ComandoRadioElectrico.Core.DAO
{
    public class AccountantAccountDAO : DAOBase<AccountantAccount>, IAccountantAccountDAO
    {
        public override FindEntityResult<AccountantAccount> Find(FindEntityParams pFindParams)
        {      
            IEnumerable<AccountantAccount> mSectBaseQry = (from t in  this.GetAll().OrderBy(m => m.Name) select t);
            
            IEnumerable<AccountantAccount> mSectFilteredQry = mSectBaseQry;            

            if (pFindParams.QuickSearchText != string.Empty)
                mSectFilteredQry = mSectBaseQry.Where(t => t.Code.Contains(pFindParams.QuickSearchText) ||
                                                           t.Name.Contains(pFindParams.QuickSearchText) );
                                                          

            int mTotalRecords = mSectFilteredQry.Count();

            //; ExpressionHelper.OrderingHelper<Client>(mSectFilteredQry, pFindParams.OrderBy, pFindParams.OrderByDirectionDescending)
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
    }
}
