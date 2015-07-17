using System;
using ComandoRadioElectrico.Core.DTO;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core.Servicios.Aplication.Interface
{
    public interface IOfficerManagementService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pOfficerId"></param>
        /// <returns></returns>
        OfficerDTO GetOfficer(int pOfficerId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pOfficerToCreate"></param>
        /// <returns></returns>
        OfficerDTO CreateOfficer(OfficerDTO pOfficerToCreate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pOfficerToUpdate"></param>
        /// <returns></returns>
        OfficerDTO UpdateOfficer(OfficerDTO pOfficerToUpdate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pOfficerToDelete"></param>
        void DeleteOfficer(DeletedEntityDTO pOfficerToDelete);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<OfficerDTO> GetAll();

    }
}
