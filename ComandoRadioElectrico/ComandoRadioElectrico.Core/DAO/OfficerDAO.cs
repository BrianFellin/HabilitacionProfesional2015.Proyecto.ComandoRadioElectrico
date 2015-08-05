using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.Model;
using ComandoRadioElectrico.Core.Services.Interfaces;
using NHibernate.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace ComandoRadioElectrico.Core.DAO
{
    public class OfficerDAO : DAOBase<Officer>, IOfficerDAO
    {
        public override FindEntityResult<Officer> Find(FindEntityParams pFindParams)
        {
            // obtenemos la sesion actual
            IDataSession mSession = this.GetSession();
            try
            {
                IEnumerable<Officer> mSectBaseQry = (from t in mSession.GetRepository<Officer>().OrderBy(m => m.FirstName) select t);

                IEnumerable<Officer> mSectFilteredQry = mSectBaseQry;

                if (pFindParams.QuickSearchText != string.Empty)
                    mSectFilteredQry = mSectBaseQry.Where(t => t.FirstName.Contains(pFindParams.QuickSearchText) ||
                                                           t.LastName.Contains(pFindParams.QuickSearchText) ||
                                                           t.DocumentNumber.Contains(pFindParams.QuickSearchText) ||
                                                           t.Telephone.Contains(pFindParams.QuickSearchText));


                int mTotalRecords = mSectFilteredQry.Count();

                IEnumerable<Officer> mOfficers = mSectFilteredQry
                            .Skip(pFindParams.SkipRecordCount)
                            .Take(pFindParams.RecordCount)
                            .OrderBy(m => m.FirstName)
                            .ToList();

                return new FindEntityResult<Officer>
                {
                    TotalRecords = mTotalRecords,
                    Result = mOfficers                    
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
