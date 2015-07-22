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

        public static IList<PartnerDTO> GetAll()
        {
            return iPartnerSvc.GetAll();
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
