using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Services.Implementations;
using ComandoRadioElectrico.Core.Services.Interfaces;
using System.Collections.Generic;

namespace ComandoRadioElectrico.WinForms.Facade
{
    public static class DocumentTypeFacade
    {
        private static IDocumentTypeService iDocumentTypeSvc = new DocumentTypeService();
        public static IList<DocumentTypeDTO> GetAll()
        {
            return iDocumentTypeSvc.GetAll();
        }
    }
}
