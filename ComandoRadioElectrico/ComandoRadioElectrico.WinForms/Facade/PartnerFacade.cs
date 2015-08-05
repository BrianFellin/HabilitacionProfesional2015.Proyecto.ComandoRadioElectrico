using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Services.Implementations;
using ComandoRadioElectrico.Core.Services.Interfaces;
using System.Collections.Generic;

namespace ComandoRadioElectrico.WinForms.Facade
{
    public static class PartnerFacade
    {
        private static IPartnerService iPartnerSvc = new PartnerService();
        public static void CreatePartner(PartnerDTO pPartner)
        {
            iPartnerSvc.CreatePartner(pPartner);
        }

        public static FindEntityResultDTO<PartnerDTO> Search(string pSearchText, int pPage)
        {
            FindEntityResultDTO<PartnerDTO> mResult = iPartnerSvc.FindPartner(new FindEntityDTO
            {
                QuickSearchText = pSearchText,
                RecordCount = 10,
                SkipRecordCount = pPage * 10,
                OrderByDirectionDescending = true
            });

            return mResult;
        }

        public static PartnerDTO Get(int pPartnerId)
        {
            return iPartnerSvc.GetPartner(pPartnerId);
        }

        public static void DeletePartner(int pPartnerId)
        {
            iPartnerSvc.DeletePartner(pPartnerId);
        }

        public static void UpdatePartner(PartnerDTO pPartnerToUpdate)
        {
            iPartnerSvc.UpdatePartner(pPartnerToUpdate);
        }
    }
}
