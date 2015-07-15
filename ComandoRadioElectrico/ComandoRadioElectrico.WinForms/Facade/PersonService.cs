using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;

namespace ComandoRadioElectrico.WinForms.Facade
{
    public class PersonService : BaseService
    {
        public void CreatePerson(PersonDTO pPerson)
        {
            IPersonManagementService mPersonSvc = this.Resolve<IPersonManagementService>();
            mPersonSvc.CreatePerson(pPerson);
        }
    }
}
