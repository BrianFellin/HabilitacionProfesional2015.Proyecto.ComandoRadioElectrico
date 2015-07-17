using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Services.Business.Interface;
using ComandoRadioElectrico.Core.Servicios.Aplication.Implementation;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;
using Microsoft.Practices.Unity;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core
{
    public class ImplementationsContainer
    {
        private static UnityContainer iUnityContainer;

        public static UnityContainer UnityContainer
        {
            get { return iUnityContainer; }
        }

        public void Initialize()
        {
            iUnityContainer = new UnityContainer();
            this.RegisterImplementations();
        }
        private void RegisterImplementations()
        {
 
           //Registros de implementaciones            
            iUnityContainer.RegisterType<IOfficerService, OfficerService>();
            iUnityContainer.RegisterType<IPersonService, PersonService>();
            iUnityContainer.RegisterType<IDocumentTypeService, DocumentTypeService>();
            iUnityContainer.RegisterType<IDocumentTypeManagementService, DocumentTypeManagementService>();
            iUnityContainer.RegisterType<IPersonManagementService, PersonManagementService>();
            iUnityContainer.RegisterType<IPartnerService, PartnerService>();
            iUnityContainer.RegisterType<IPartnerManagementService, PartnerManagementService>();
            iUnityContainer.RegisterType<IOfficerManagementService, OfficerManagementService>();

            
        }
    }                    
}
