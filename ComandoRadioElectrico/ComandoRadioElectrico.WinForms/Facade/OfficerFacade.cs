using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Services.Implementations;
using ComandoRadioElectrico.Core.Services.Interfaces;
using System.Collections.Generic;

namespace ComandoRadioElectrico.WinForms.Facade
{
    public static class OfficerFacade 
    {
        private static IOfficerService iOfficerSvc = new OfficerService();       
        public static IEnumerable<OfficerDTO> GetAllOfficer()
        {
            return iOfficerSvc.GetAll();
        }
        
        public static void CreateOfficer(OfficerDTO pOfficer)
        {
            iOfficerSvc.CreateOfficer(pOfficer);
        }

        public static void UpdateOfficer(OfficerDTO pOfficer)
        {
            iOfficerSvc.UpdateOfficer(pOfficer);
        }

        public static void DeleteOfficer(OfficerDTO pOfficer)
        {
            iOfficerSvc.DeleteOfficer(pOfficer);
        }

        public static FindEntityResultDTO<OfficerDTO> Search(string pSearchText, int pPage)
        {
            FindEntityResultDTO<OfficerDTO> mResult = iOfficerSvc.FindOfficer(new FindEntityDTO
            {
                QuickSearchText = pSearchText,
                RecordCount = 10,
                SkipRecordCount = pPage * 10,
                OrderByDirectionDescending = true
            });

            return mResult;
        }
    }
}
