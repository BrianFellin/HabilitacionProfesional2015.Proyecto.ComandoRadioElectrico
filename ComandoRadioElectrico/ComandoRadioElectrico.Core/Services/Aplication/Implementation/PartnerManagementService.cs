using AutoMapper;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.NHibernate.Model;
using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Services.Business.Interface;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;
using System.Collections.Generic;
using System.Linq;

using System;
using System.Text.RegularExpressions;

namespace ComandoRadioElectrico.Core.Servicios.Aplication.Implementation
{
    public class PartnerManagementService : BaseService, IPartnerManagementService
    {
        //public PartnerDTO GetPartner(int pPartnerId)
        //{ 
            
        //    // obtencion del servicio de socios
        //    IPartnerService mPartnerService = this.Resolve<IPartnerService>();            
        //    Partner mPartner = mPartnerService.GetById(pPartnerId);
        //    if (mPartner == null)
        //        throw new System.InvalidOperationException(string.Format("Socio no encontrado", pPartnerId));

        //    return Mapper.Map<PartnerDTO>(mPartner);
        //}

        public PartnerDTO CreatePartner(PartnerDTO pPartnerToCreate)
        {            
            
            //////Se controla valores especiales//////
            if (Regex.IsMatch(pPartnerToCreate.Person.DocumentNumber, @"\A[0-9]{2}(\.)[0-9]{3}(\.)[0-9]{3}\Z") 
                    || Regex.IsMatch(pPartnerToCreate.Person.Telephone, @"^\+?\d{1,3}?[- .]?\(?(?:\d{2,3})\)?[- .]?\d\d\d[- .]?\d\d\d\d$")
                    || !Regex.IsMatch(pPartnerToCreate.ValueQuota.ToString(), @"^(\d+)(\d|\.\d)?\d*$")
                    || pPartnerToCreate.ValueQuota.ToString().Length == 0)
            {
                throw new InvalidFormatException("No cumple con el formato");
            }
            
            //Mapeamos el parametro de entrada de tipo PartnerDTO a Partner
            Partner mNewPartner = Mapper.Map<PartnerDTO, Partner>(pPartnerToCreate);

            // obtencion del servicio de la persona
            IPersonManagementService mPersonSvc = this.Resolve<PersonManagementService>();

            ////// INCIA EL CONTROL NECESARIO PARA VERIFICAR LA PERSONA //////
            if (pPartnerToCreate.Person.Id != 0) 
            {
                if (mPersonSvc.GetPerson(pPartnerToCreate.Person.Id) != null)
                {
                    //Se asigna la Persona que se localizo por Id.
                    mNewPartner.Person = Mapper.Map<PersonDTO,Person>(mPersonSvc.GetPerson(pPartnerToCreate.Person.Id));
                }
            }
            else
            {                
                if (pPartnerToCreate.Person.DocumentNumber == string.Empty 
                    || pPartnerToCreate.Person.DocumentNumber == string.Empty
                    || pPartnerToCreate.Person.DocumentTypeId == 0
                    || pPartnerToCreate.Person.Domicile == string.Empty
                    || pPartnerToCreate.Person.FirstName == string.Empty
                    || pPartnerToCreate.Person.LastName == string.Empty
                    || pPartnerToCreate.Person.Telephone == string.Empty)
                {
                    throw new DataFieldException("Campos de datos obligatorios estan vacios");
                }
                else
                {
                    if (mPersonSvc.GetPersonForDocument(pPartnerToCreate.Person.DocumentNumber) != null)
                    {
                        //Como la persona existe, ya que se la ense contro por número de documento, se la asigna al socio.
                        mNewPartner.Person = Mapper.Map<PersonDTO, Person>(mPersonSvc.GetPersonForDocument(pPartnerToCreate.Person.DocumentNumber));
                    }
                    else
                    { 
                        //Se crea la persona y se agrega al socio
                        mNewPartner.Person = Mapper.Map<PersonDTO, Person>(mPersonSvc.CreatePerson(pPartnerToCreate.Person));
                    }
                }               
                
            }
            ////// FINALIZA EL CONTROL NECESARIO PARA VERIFICAR LA PERSONA //////
            // obtencion del servicio del cobrador
            IOfficerService mOfficerSvc = this.Resolve<IOfficerService>();

            if (pPartnerToCreate.CollectDay == null 
                    || pPartnerToCreate.CollectDomicile == string.Empty
                    || pPartnerToCreate.StarDate == null)
                {
                    throw new DataFieldException("Campos de datos obligatorios estan vacios");
                }
            
            // Se controla que no exista el socio
            foreach (PartnerDTO partner in this.GetAll())
            {
                if (partner == Mapper.Map<Partner,PartnerDTO>(mNewPartner))
                {
                    throw new PartnerException("Ya existe el socio, por favor verifique los datos");
                }
            }


            //Se asigna el cobrador.
            mNewPartner.Officer = mOfficerSvc.GetById(pPartnerToCreate.Officer.Id);
            if (mNewPartner.Officer == null)
            {
                throw new NullReferenceException("No se asigno el cobrador");
            }
            //Obtencion del servicio de socios 
            IPartnerService mPartnerSvc = new PartnerService();
            ////// INCIA EL CONTROL NECESARIO PARA VERIFICAR EL SOCIO //////

            //Se presiste el soción
            Partner mPartner = mPartnerSvc.Create(mNewPartner);
            // adaptamos y devolvemos el resultado
            return Mapper.Map<Partner, PartnerDTO>(mPartner);
            ////// FINALIZA EL CONTROL NECESARIO PARA VERIFICAR EL SOCIO //////
        }

        //public PartnerDTO UpdatePartner(PartnerDTO pPartnerToUpdate)
        //{
        //    // validamos parametro de entrada
        //    if (pPartnerToUpdate == null) throw new System.ArgumentNullException("pPartnerToUpdate");

        //    // obtencion del servicio de socios 
        //    IPartnerService mPartnerSvc = new PartnerService(); 

        //    // obtenemos el objeto a modificar
        //    Partner mPartnerToUpdate = mPartnerSvc.GetById(pPartnerToUpdate.Id);

        //    // validamos que se haya encontrado el socio
        //    if (mPartnerToUpdate == null) throw new System.InvalidOperationException(string.Format("Socio no encontrado", pPartnerToUpdate.Id));

        //   /* // obtencion del servicio de socio
        //    if (pPartnerToUpdate.ClientTypeId != mClientToUpdate.ClientType.Id)
        //    {
        //        // obtenemos el tipo de cliente
        //        IClientTypeService mClientTypeSvc = this.Resolve<IClientTypeService>();
        //        mClientToUpdate.ClientType = mClientTypeSvc.GetById(pClientToUpdate.ClientTypeId);
        //    } */
        //    Mapper.Map<PartnerDTO, Partner>(pPartnerToUpdate, mPartnerToUpdate);

        //    // actualizamos la entidad
        //    mPartnerSvc.Update(mPartnerToUpdate);

        //    return Mapper.Map<PartnerDTO>(mPartnerToUpdate);

        //}

        //public void DeletePartner(DeletedEntityDTO pPartnerToDelete)
        //{
        //    // obtencion del servicio de socios
        //    IPartnerService mPartnerSvc = new PartnerService(); 

        //    // eliminamos el socio
        //    mPartnerSvc.Delete(pPartnerToDelete.Id);
        //}

        public IList<PartnerDTO> GetAll()
        {
            // obtencion del servicio de tipo de documento
            IPartnerService mPartnerService = this.Resolve<IPartnerService>();
            // Devolución de los Socios, el maper los convierte del tipo Partner a PartnerDTO (tipo que maneja el .Core)
            return Mapper.Map<IList<Partner>, IList<PartnerDTO>>(mPartnerService.GetAll().ToList());
        }

        public PartnerDTO GetPartner(int pPartnerId)
        {
            // obtencion del servicio de tipo de documento
            IPartnerService mPartnerService = this.Resolve<IPartnerService>();

            return Mapper.Map<Partner, PartnerDTO>(mPartnerService.GetById(pPartnerId));
        }

        public PartnerDTO UpdatePartner(PartnerDTO pPartnerToUpdate)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePartner(DeletedEntityDTO pPartnerToDelete)
        {
            throw new System.NotImplementedException();
        }
    }
}
