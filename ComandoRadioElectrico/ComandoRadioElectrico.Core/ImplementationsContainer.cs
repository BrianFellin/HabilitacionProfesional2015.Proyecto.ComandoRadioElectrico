using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Services.Business.Interface;
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
        }
    }                    
}
