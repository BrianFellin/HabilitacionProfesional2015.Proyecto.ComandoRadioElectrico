using ComandoRadioElectrico.Core.DAO.DAOBase;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.Model;
using ComandoRadioElectrico.Core.Services.Interfaces;
using ComandoRadioElectrico.Core.Utils;
using NHibernate.Cfg;
using NHibernate.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComandoRadioElectrico.Core.DAO
{
    public class QuotaDAO : DAOBase<Quota>, IQuotaDAO 
    {
        public override FindEntityResult<Quota> Find(FindEntityParams pFindParams)
        {
            throw new NotImplementedException();
        }
        
        public void GenerateQuotas(MonthPeriod pMonth, int pYear)
        {
            IDataSession mSession = this.GetSession();
            try
            {
                mSession.BeginTransaction();
                //Se valida que ya no exista otro periodo igual
                //if ((from p in mSession.GetRepository<GeneratedPeriod>() where p.Month == pMonth.ToString() & p.Year == pYear select p).Count() > 0)
                  //  throw new BusinessException("El período que se desea generar ya ha sido generado");

                //Creo el periodo de cuotas y obtengo el ID
                int mIdPeriod = mSession.Save(new GeneratedPeriod { Month = pMonth.ToString(), Year = pYear });

                GeneratedPeriod mPeriod = mSession.Get<GeneratedPeriod>(mIdPeriod);

                //Por cada socio que corresponde generarle la cuota para el periodo actual,
                //se crea una nueva cuota
                foreach (Partner p in (from p in mSession.GetRepository<Partner>() where p.QuotaRegime == p.QuotaCounter select p).ToList())
                {
                    mSession.Save(new Quota
                    {
                        IsPaid = false,
                        Period = mPeriod,
                        Partner = p,
                        Amount = p.ValueQuota
                    });
                }                
                //Actualizo los contadores de los socios
                foreach (Partner p in (from p in mSession.GetRepository<Partner>() select p).ToList())
                {
                    p.QuotaCounter--;
                    if (p.QuotaCounter == 0)
                    {
                        p.QuotaCounter = p.QuotaRegime;
                    }
                    mSession.SaveOrUpdate(p);
                }
                mSession.Commit();                
            }
            catch (GenericADOException ex)
            {
                mSession.RollBack();
                throw new DataBaseException("Error en el acceso a los datos, intente mas tarde", ex);
            }
            finally
            {
                mSession.Dispose();
            }
        }
    }
}
