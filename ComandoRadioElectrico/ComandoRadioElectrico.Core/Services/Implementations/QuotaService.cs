using AutoMapper;
using ComandoRadioElectrico.Core.DAO;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.Services.Interfaces;
using ComandoRadioElectrico.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Services.Implementations
{
    public class QuotaService : BaseService, IQuotaService
    {
        private IQuotaDAO iQuotaDAO;
        private IGeneratedPeriodDAO iGeneratedPeriodDAO;
        
        public QuotaService()
        {
            this.iQuotaDAO = this.Resolve<IQuotaDAO>();
            this.iGeneratedPeriodDAO = this.Resolve<IGeneratedPeriodDAO>();
        }
           
        public IList<QuotaDTO> GetQuotasForPartner(int pIdPartner)
        {
 	        throw new NotImplementedException();
        }

        IList<QuotaDTO> IQuotaService.GetAll()
        {
 	        throw new NotImplementedException();
        }

        public void Pay(QuotaDTO pQuotaToPay)
        {
 	        throw new NotImplementedException();
        }

        public void GenerateQuotas(MonthPeriod pPeriod, int pYear)
        {
            //Valido parametro de entrada
            if (pPeriod == null) throw new ArgumentNullException("pPeriod");

            //Valido que ya no exista otro periodo igual
            if ((from p in this.iGeneratedPeriodDAO.GetAll() where p.Month == pPeriod.ToString() & p.Year == pYear select p).Count() > 0)
                throw new BusinessException("El período que se desea generar ya ha sido generado");
            


        }
    }
}
