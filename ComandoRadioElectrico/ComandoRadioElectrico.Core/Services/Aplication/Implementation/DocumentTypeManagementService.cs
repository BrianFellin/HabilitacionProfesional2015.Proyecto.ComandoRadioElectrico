using AutoMapper;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.NHibernate.Model;
using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Services.Business.Interface;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;

namespace ComandoRadioElectrico.Core.Servicios.Aplication.Implementation
{
    public class DocumentTypeManagementService : BaseService, IDocumentTypeManagementService
    {
        public DocumentTypeDTO GetDocumentType(int pDocumentTypeId)
        {             
            // obtencion del servicio de tipo de documento
            IDocumentTypeService mDocumentTypeService = this.Resolve<IDocumentTypeService>();            
            DocumentType mDocumentType = mDocumentTypeService.GetById(pDocumentTypeId);
            if (mDocumentType == null)
                throw new System.InvalidOperationException(string.Format("Tipo de documento no encontrado", pDocumentTypeId));

            return Mapper.Map<DocumentTypeDTO>(mDocumentType);
        }


        // Los metodos siguientes no se implementaran ya que no son necesarios.
        
        public DocumentTypeDTO CreateDocumentType(DocumentTypeDTO pDocumentTypeToCreate)
        {
            throw new System.NotImplementedException();
        }

        public DocumentTypeDTO UpdateDocumentType(DocumentTypeDTO pDocumentTypeToUpdate)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteDocumentType(DeletedEntityDTO pDocumentTypeToDelete)
        {
            throw new System.NotImplementedException();
        }
    }
}
