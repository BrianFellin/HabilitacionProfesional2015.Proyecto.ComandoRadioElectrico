using AutoMapper;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.NHibernate.Model;
using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Services.Business.Interface;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;
using System.Collections.Generic;
using System.Linq;

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
            //Mapeamos el parametro de entrada de tipo PartnerDTO a Partner
            Partner mNewSocio = Mapper.Map<PartnerDTO, Partner>(pPartnerToCreate);

            // obtencion del servicio de la persona
            IPersonService mPersonSvc = this.Resolve<IPersonService>();
            //Se asigna la Persona.
            mNewSocio.Person = mPersonSvc.GetById(pPartnerToCreate.Person.Id);
            // obtencion del servicio del cobrador
            IOfficerService mOfficerSvc = this.Resolve<IOfficerService>();            
            //Se asigna el cobrador.
            mNewSocio.Officer = mOfficerSvc.GetById(pPartnerToCreate.Officer.Id);
            //Obtencion del servicio de socios 
            IPartnerService mPartnerSvc = new PartnerService();
            //Se presiste el soción
            Partner mPartner = mPartnerSvc.Create(mNewSocio);
            // adaptamos y devolvemos el resultado
            return Mapper.Map<Partner, PartnerDTO>(mPartner);       
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
