using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;
using System.Collections.Generic;

namespace ComandoRadioElectrico.WinForms.Facade
{
    public class OfficerService : BaseService
    {
        private static OfficerService iOfficerSvc;

        private OfficerService() { }
        public static OfficerService GetInstance
        {
            get
            {
                if (iOfficerSvc == null)
                {
                    iOfficerSvc = new OfficerService();
                }
                return iOfficerSvc;
            }
        }

        public IList<OfficerDTO> GetAllOfficer()
        {
            IOfficerManagementService mOfficerSvc = this.Resolve<IOfficerManagementService>();
            return mOfficerSvc.GetAll();
        }
    }
}
