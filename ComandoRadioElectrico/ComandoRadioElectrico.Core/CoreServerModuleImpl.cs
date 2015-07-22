using ComandoRadioElectrico.Core.DAO;
using ComandoRadioElectrico.Core.Services.Implementations;
using ComandoRadioElectrico.Core.Services.Interfaces;
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

            #region Servicios DAO
            iUnityContainer.RegisterType<IAccountTypeDAO, AccountTypeDAO>();
            iUnityContainer.RegisterType<IDocumentTypeDAO, DocumentTypeDAO>();
            iUnityContainer.RegisterType<IAccountantAccountDAO, AccountantAccountDAO>();
            iUnityContainer.RegisterType<IPartnerDAO, PartnerDAO>();
            iUnityContainer.RegisterType<IOfficerDAO, OfficerDAO>();
            iUnityContainer.RegisterType<IPersonDAO, PersonDAO>();
            iUnityContainer.RegisterType<IGeneratedPeriodDAO, GeneratedPeriodDAO>();
            iUnityContainer.RegisterType<IQuotaDAO, QuotaDAO>();

            #endregion

            #region Otros servicios
            MappingHelper.CreateMaps();
            #endregion
        }
    }                    
}
