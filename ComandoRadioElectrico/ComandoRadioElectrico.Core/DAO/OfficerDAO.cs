using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.NHibernate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.DAO
{
    public class OfficerDAO : DAOBase<Officer>, IOfficerDAO
    {
        public override FindEntityResult<Officer> Find(FindEntityParams pFindParams)
        {
            IEnumerable<Officer> mSectBaseQry = (from t in this.GetAll().OrderBy(m => m.Person.FirstName) select t);

            IEnumerable<Officer> mSectFilteredQry = mSectBaseQry;

            if (pFindParams.QuickSearchText != string.Empty)
                mSectFilteredQry = mSectBaseQry.Where(t => t.Person.FirstName.Contains(pFindParams.QuickSearchText) ||
                                                           t.Code.Contains(pFindParams.QuickSearchText) ||
                                                           t.Person.LastName.Contains(pFindParams.QuickSearchText) ||
                                                           t.Person.DocumentNumber.Contains(pFindParams.QuickSearchText)||
                                                           t.Person.Telephone.Contains(pFindParams.QuickSearchText));


            int mTotalRecords = mSectFilteredQry.Count();
            
            IEnumerable<Officer> mAccounts = mSectFilteredQry
                            .Skip(pFindParams.SkipRecordCount)
                            .Take(pFindParams.RecordCount)
                            .OrderBy(m => m.Person.FirstName)
                            .ToList();

            return new FindEntityResult<Officer>
            {
                TotalRecords = mTotalRecords,
                Result = mAccounts
            };
        }
    }
}
