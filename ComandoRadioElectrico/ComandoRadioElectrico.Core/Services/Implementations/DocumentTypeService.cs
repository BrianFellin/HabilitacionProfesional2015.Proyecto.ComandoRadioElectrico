using AutoMapper;
using ComandoRadioElectrico.Core.DAO;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Model;
using ComandoRadioElectrico.Core.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ComandoRadioElectrico.Core.Services.Implementations
{
    public class DocumentTypeService : BaseService, IDocumentTypeService
    {
        private IDocumentTypeDAO iDocumentTypeDAO;

        public DocumentTypeService()
        {
            this.iDocumentTypeDAO = this.Resolve<IDocumentTypeDAO>();
        }
        public DocumentTypeDTO GetDocumentType(int pDocumentTypeId)
        {                                  
            DocumentType mDocumentType = this.iDocumentTypeDAO.GetById(pDocumentTypeId);
            if (mDocumentType == null)
                throw new System.InvalidOperationException(string.Format("Tipo de documento no encontrado", pDocumentTypeId));

            return Mapper.Map<DocumentTypeDTO>(mDocumentType);
        }


        // Los metodos siguientes no se implementaran ya que no son necesarios.
        
        
        public void DeleteDocumentType(DeletedEntityDTO pDocumentTypeToDelete)
        {
            throw new System.NotImplementedException();
        }


        public IList<DocumentTypeDTO> GetAll()
        {
            return Mapper.Map<IList<DocumentType>, IList<DocumentTypeDTO>>(this.iDocumentTypeDAO.GetAll().ToList());            
        }


        public void CreateDocumentType(DocumentTypeDTO pDocumentTypeToCreate)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateDocumentType(DocumentTypeDTO pDocumentTypeToUpdate)
        {
            throw new System.NotImplementedException();
        }
    }
}
