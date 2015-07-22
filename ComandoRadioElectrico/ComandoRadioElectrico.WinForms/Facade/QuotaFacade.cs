using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Services.Implementations;
using ComandoRadioElectrico.Core.Services.Interfaces;
using ComandoRadioElectrico.Core.Utils;
using System.Collections.Generic;

namespace ComandoRadioElectrico.WinForms.Facade
{
    public static class QuotaFacade
    {
        private static IQuotaService iQuotaSvc = new QuotaService();
        public static void GenerateQuotas(MonthPeriod pMonth, int pYear)
        {
            iQuotaSvc.GenerateQuotas(pMonth, pYear);
        }

       
    }
}
