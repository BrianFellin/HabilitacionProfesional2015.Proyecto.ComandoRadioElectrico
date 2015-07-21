using System;
using ComandoRadioElectrico.Core.DTO;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core.Services.Interfaces
{
    public interface IPartnerService
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
        void CreatePartner(PartnerDTO pPartnerToCreate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPartnerToUpdate"></param>
        /// <returns></returns>
        void UpdatePartner(PartnerDTO pPartnerToUpdate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPartnerToDelete"></param>
        void DeletePartner(DeletedEntityDTO pPartnerToDelete);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<PartnerDTO> GetAll();

    }
}
