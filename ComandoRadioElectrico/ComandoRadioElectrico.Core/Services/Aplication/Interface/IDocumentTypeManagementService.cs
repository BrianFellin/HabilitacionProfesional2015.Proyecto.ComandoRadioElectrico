using System;
using ComandoRadioElectrico.Core.DTO;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core.Servicios.Aplication.Interface
{
    public interface IDocumentTypeManagementService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDocumentTypeId"></param>
        /// <returns></returns>
        DocumentTypeDTO GetDocumentType(int pDocumentTypeId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDocumentTypeToCreate"></param>
        /// <returns></returns>
        DocumentTypeDTO CreateDocumentType(DocumentTypeDTO pDocumentTypeToCreate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDocumentTypeToUpdate"></param>
        /// <returns></returns>
        DocumentTypeDTO UpdateDocumentType(DocumentTypeDTO pDocumentTypeToUpdate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDocumentTypeToDelete"></param>
        void DeleteDocumentType(DeletedEntityDTO pDocumentTypeToDelete);

        IList<DocumentTypeDTO> GetAll();

    }
}
