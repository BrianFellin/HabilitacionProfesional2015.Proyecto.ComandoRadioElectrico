using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.NHibernate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.DAO
{
    public class PartnerDAO : DAOBase<Partner>, IPartnerDAO
    {
        public override FindEntityResult<Partner> Find(FindEntityParams pFindParams)
        {
            IEnumerable<Partner> mSectBaseQry = (from t in this.GetAll().OrderBy(m => m.Person.FirstName) select t);

            IEnumerable<Partner> mSectFilteredQry = mSectBaseQry;

            if (pFindParams.QuickSearchText != string.Empty)
                mSectFilteredQry = mSectBaseQry.Where(t => t.Code.Contains(pFindParams.QuickSearchText) 
                                                           ||t.Person.FirstName.Contains(pFindParams.QuickSearchText)
                                                           ||t.Person.LastName.Contains(pFindParams.QuickSearchText)
                                                           ||t.Person.Domicile.Contains(pFindParams.QuickSearchText)
                                                           ||t.Person.Telephone.Contains(pFindParams.QuickSearchText));


            int mTotalRecords = mSectFilteredQry.Count();
            
            IEnumerable<Partner> mPartners = mSectFilteredQry
                            .Skip(pFindParams.SkipRecordCount)
                            .Take(pFindParams.RecordCount)
                            .OrderBy(m => m.Person.FirstName)
                            .ToList();

            return new FindEntityResult<Partner>
            {
                TotalRecords = mTotalRecords,
                Result = mPartners
            };
        }
    }
}
