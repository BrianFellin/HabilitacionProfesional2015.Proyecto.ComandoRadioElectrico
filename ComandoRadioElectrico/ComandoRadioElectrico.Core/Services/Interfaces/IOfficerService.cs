using System;
using ComandoRadioElectrico.Core.DTO;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core.Services.Interfaces
{
    public interface IOfficerService
    {   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pOfficerToCreate"></param>
        /// <returns></returns>
        void CreateOfficer(OfficerDTO pOfficerToCreate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pOfficerToUpdate"></param>
        /// <returns></returns>
        void UpdateOfficer(OfficerDTO pOfficerToUpdate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pOfficerToDelete"></param>
        void DeleteOfficer(OfficerDTO pOfficerToDelete);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<OfficerDTO> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pCriteria"></param>
        /// <returns></returns>
        FindEntityResultDTO<OfficerDTO> FindOfficer(FindEntityDTO pCriteria);

    }
}
