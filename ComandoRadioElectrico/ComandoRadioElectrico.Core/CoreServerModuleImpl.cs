using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Services.Business.Interface;
using ComandoRadioElectrico.Core.Servicios.Aplication.Implementation;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;
using ComandoRadioElectrico.Core.Utils;
using Microsoft.Practices.Unity;
using System.Collections.Generic;

namespace ComandoRadioElectrico.Core
{
    public static class CoreServerModuleImpl
    {
        private static UnityContainer iUnityContainer;

        public static UnityContainer UnityContainer
        {
            get { return iUnityContainer; }
        }

        public static void Initialize()
        {
            iUnityContainer = new UnityContainer();
            Configure();
        }
        private static void Configure()
        {
            #region Servicios de aplicacion                     
            iUnityContainer.RegisterType<IPersonManagementService, PersonManagementService>();
            iUnityContainer.RegisterType<IAccountantAccountManagementService, AccountantAccountManagementService>();
            iUnityContainer.RegisterType<IDocumentTypeManagementService, DocumentTypeManagementService>();
            iUnityContainer.RegisterType<IAccountTypeManagementService, AccountTypeManagementService>();            
            #endregion
 
            #region Servicios internos
            iUnityContainer.RegisterType<IPartnerService, PartnerService>();
           //Registros de implementaciones            
            iUnityContainer.RegisterType<IOfficerService, OfficerService>();
            iUnityContainer.RegisterType<IPersonService, PersonService>();
            iUnityContainer.RegisterType<IDocumentTypeService, DocumentTypeService>();
            iUnityContainer.RegisterType<IDocumentTypeManagementService, DocumentTypeManagementService>();
            iUnityContainer.RegisterType<IPersonManagementService, PersonManagementService>();
            iUnityContainer.RegisterType<IPartnerService, PartnerService>();
            iUnityContainer.RegisterType<IPartnerManagementService, PartnerManagementService>();
            iUnityContainer.RegisterType<IOfficerManagementService, OfficerManagementService>();

            iUnityContainer.RegisterType<IAccountantAccountService, AccountantAccountService>();
            iUnityContainer.RegisterType<IAccountTypeService, AccountTypeService>();
            
            #endregion
            
            #region Otros servicios
            MappingHelper.CreateMaps();
            #endregion
        }
    }                    
}
