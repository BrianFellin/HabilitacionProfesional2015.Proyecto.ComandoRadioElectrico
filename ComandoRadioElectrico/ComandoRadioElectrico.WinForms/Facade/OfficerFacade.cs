using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Services.Implementations;
using ComandoRadioElectrico.Core.Services.Interfaces;
using System.Collections.Generic;

namespace ComandoRadioElectrico.WinForms.Facade
{
    public static class OfficerFacade 
    {
        private static IOfficerService iOfficerSvc = new OfficerService();

        public static IList<OfficerDTO> GetAllOfficer()
        {
            return iOfficerSvc.GetAll();
        }
    }
}
