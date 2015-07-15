using System;
using ComandoRadioElectrico.Core.DTO;

namespace ComandoRadioElectrico.Core.Servicios.Aplication.Interface
{
    public interface IPersonManagementService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPersonId"></param>
        /// <returns></returns>
        PersonDTO GetPerson(int pPersonId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPersonToCreate"></param>
        /// <returns></returns>
        PersonDTO CreatePerson(PersonDTO pPersonToCreate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPersonToUpdate"></param>
        /// <returns></returns>
        PersonDTO UpdatePerson(PersonDTO pPersonToUpdate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPersonToDelete"></param>
        void DeletePerson(DeletedEntityDTO pPersonToDelete);

    }
}
