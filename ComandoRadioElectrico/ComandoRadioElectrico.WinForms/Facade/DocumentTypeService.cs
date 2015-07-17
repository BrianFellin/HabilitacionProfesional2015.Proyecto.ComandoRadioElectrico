using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;
using System.Collections.Generic;

namespace ComandoRadioElectrico.WinForms.Facade
{
    public class DocumentTypeService : BaseService
    {
        private static DocumentTypeService iDocumentTypeSvc;

        private DocumentTypeService() { }
        public static DocumentTypeService GetInstance
        {
            get
            {
                if (iDocumentTypeSvc == null)
                {
                    iDocumentTypeSvc = new DocumentTypeService();
                }
                return iDocumentTypeSvc;
            }
        }
        public IList<DocumentTypeDTO> GetAll()
        {
            IDocumentTypeManagementService mDocumentTypeSvc = this.Resolve<IDocumentTypeManagementService>();
            return mDocumentTypeSvc.GetAll();
        }
    }
}
