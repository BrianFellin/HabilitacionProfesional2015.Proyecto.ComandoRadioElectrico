using AutoMapper;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.NHibernate.Model;
using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Services.Business.Interface;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;

namespace ComandoRadioElectrico.Core.Servicios.Aplication.Implementation
{
    public class PersonManagementService : BaseService, IPersonManagementService
    {
        public PersonDTO GetPerson(int pPersonId)
        { 
            
            // obtencion del servicio de socios
            IPersonService mPersonService = this.Resolve<IPersonService>();            
            Person mPerson = mPersonService.GetById(pPersonId);
            //if (mPerson == null)
              //  throw new System.InvalidOperationException(string.Format("Socio no encontrado", pPersonId));

            return Mapper.Map<PersonDTO>(mPerson);
        }

        public PersonDTO GetPersonForDocument(string pDocument)
        {

            // obtencion del servicio de socios
            IPersonService mPersonService = this.Resolve<IPersonService>();
            Person mPerson = null;
            foreach (Person pPerson in mPersonService.GetAll())
            {
                if (pPerson.DocumentNumber == pDocument)
                {
                    mPerson = pPerson;
                }
            }
            return Mapper.Map<PersonDTO>(mPerson);
        }

        public PersonDTO CreatePerson(PersonDTO pPersonToCreate)
        {            
            // creamos el objeto persona
            Person mNewPerson = Mapper.Map<PersonDTO, Person>(pPersonToCreate);

            // obtencion del servicio de persona
            IDocumentTypeService mDocumentTypeSvc = this.Resolve<IDocumentTypeService>();

            mNewPerson.DocumentType = mDocumentTypeSvc.GetById(pPersonToCreate.DocumentTypeId);

            // obtencion del servicio de personas
            IPersonService mPersonSvc = this.Resolve<IPersonService>();
         
            // persistimos la informacion 
            Person mPerson = mPersonSvc.Create(mNewPerson);

            // adaptamos y devolvemos el resultado
            return Mapper.Map<Person, PersonDTO>(mPerson);   
        }

        public PersonDTO UpdatePerson(PersonDTO pPersonToUpdate)
        {
            // validamos parametro de entrada
            if (pPersonToUpdate == null) throw new System.ArgumentNullException("pPersonToUpdate");

            // obtencion del servicio de socios 
            IPersonService mPersonSvc = new PersonService(); 

            // obtenemos el objeto a modificar
            Person mPersonToUpdate = mPersonSvc.GetById(pPersonToUpdate.Id);

            // validamos que se haya encontrado el socio
            if (mPersonToUpdate == null) throw new System.InvalidOperationException(string.Format("Socio no encontrado", pPersonToUpdate.Id));

           /* // obtencion del servicio de socio
            if (pPersonToUpdate.ClientTypeId != mClientToUpdate.ClientType.Id)
            {
                // obtenemos el tipo de cliente
                IClientTypeService mClientTypeSvc = this.Resolve<IClientTypeService>();
                mClientToUpdate.ClientType = mClientTypeSvc.GetById(pClientToUpdate.ClientTypeId);
            } */
            Mapper.Map<PersonDTO, Person>(pPersonToUpdate, mPersonToUpdate);

            // actualizamos la entidad
            mPersonSvc.Update(mPersonToUpdate);

            return Mapper.Map<PersonDTO>(mPersonToUpdate);

        }

        public void DeletePerson(DeletedEntityDTO pPersonToDelete)
        {
            // obtencion del servicio de socios
            IPersonService mPersonSvc = new PersonService(); 

            // eliminamos el socio
            mPersonSvc.Delete(pPersonToDelete.Id);
        }
    }
}
