using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Services.Business.Interface;
using ComandoRadioElectrico.Core.Servicios.Aplication.Implementation;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;
using Microsoft.Practices.Unity;

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
            iUnityContainer.RegisterType<IPartnerService, PartnerService>();
            iUnityContainer.RegisterType<IPersonService, PersonService>();
            iUnityContainer.RegisterType<IDocumentTypeService, DocumentTypeService>();
            iUnityContainer.RegisterType<IPersonManagementService, PersonManagementService>();
            
        }
    }                    
}
