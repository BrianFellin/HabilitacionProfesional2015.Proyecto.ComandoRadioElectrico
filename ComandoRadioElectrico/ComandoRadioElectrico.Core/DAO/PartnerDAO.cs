using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.Model;
using ComandoRadioElectrico.Core.Services.Interfaces;
using NHibernate.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace ComandoRadioElectrico.Core.DAO
{
    public class PartnerDAO : DAOBase<Partner>, IPartnerDAO
    {
        public override FindEntityResult<Partner> Find(FindEntityParams pFindParams)
        {
            // obtenemos la sesion actual
            IDataSession mSession = this.GetSession();
            try
            {
                IEnumerable<Partner> mSectBaseQry = (from t in mSession.GetRepository<Partner>().OrderBy(m => m.FirstName) select t);

                IEnumerable<Partner> mSectFilteredQry = mSectBaseQry;

                if (pFindParams.QuickSearchText != string.Empty)
                    mSectFilteredQry = mSectBaseQry.Where(t => t.FirstName.Contains(pFindParams.QuickSearchText)
                                                           || t.LastName.Contains(pFindParams.QuickSearchText)
                                                           || t.Domicile.Contains(pFindParams.QuickSearchText)
                                                           || t.Telephone.Contains(pFindParams.QuickSearchText));


                int mTotalRecords = mSectFilteredQry.Count();

                IEnumerable<Partner> mPartners = mSectFilteredQry
                            .Skip(pFindParams.SkipRecordCount)
                            .Take(pFindParams.RecordCount)
                            .OrderBy(m => m.FirstName)
                            .ToList();

                return new FindEntityResult<Partner>
                {
                    TotalRecords = mTotalRecords,
                    Result = mPartners
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
