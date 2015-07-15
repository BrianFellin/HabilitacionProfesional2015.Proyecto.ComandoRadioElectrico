using System;
using ComandoRadioElectrico.Core1.DTO;

namespace ComandoRadioElectrico.Core1.Servicios.Aplication.Interface
{
    public interface IPartnerManagementService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPartnerId"></param>
        /// <returns></returns>
        PartnerDTO GetPartner(int pPartnerId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPartnerToCreate"></param>
        /// <returns></returns>
        PartnerDTO CreatePartner(PartnerDTO pPartnerToCreate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPartnerToUpdate"></param>
        /// <returns></returns>
        PartnerDTO UpdatePartner(PartnerDTO pPartnerToUpdate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPartnerToDelete"></param>
        void DeletePartner(DeletedEntityDTO pPartnerToDelete);

    }
}
