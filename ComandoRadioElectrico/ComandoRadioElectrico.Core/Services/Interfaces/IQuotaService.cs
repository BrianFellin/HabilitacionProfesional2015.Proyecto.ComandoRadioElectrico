using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Services.Interfaces
{
    public interface IQuotaService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pQuotaId"></param>
        /// <returns></returns>
        IList<QuotaDTO> GetQuotasOfPartner(int pIdPartner);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pQuotaToPay"></param>
        void Pay(int pIdQuotaToPay);

        void GenerateQuotas(MonthPeriod pMonth, int pYear);

    }
}
