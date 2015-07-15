using AutoMapper;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.NHibernate.Model;
using ComandoRadioElectrico.Core.Services.Business.Implementation;
using ComandoRadioElectrico.Core.Services.Business.Interface;
using ComandoRadioElectrico.Core.Servicios.Aplication.Interface;

namespace ComandoRadioElectrico.Core.Servicios.Aplication.Implementation
{
    public class PartnerManagementService : IPartnerManagementService
    {
        public PartnerDTO GetPartner(int pPartnerId)
        { 
            
            // obtencion del servicio de socios
            IPartnerService mPartnerService = new PartnerService();
            Partner mPartner = mPartnerService.GetById(pPartnerId);
            if (mPartner == null)
                throw new System.InvalidOperationException(string.Format("Socio no encontrado", pPartnerId));

            return Mapper.Map<PartnerDTO>(mPartner);
        }

        public PartnerDTO CreatePartner(PartnerDTO pPartnerToCreate)
        {
            // obtencion del servicio de socios 
            IPartnerService mPartnerSvc = new PartnerService();

            // creamos el objeto socio
            Partner mNewPartner = Mapper.Map<PartnerDTO, Partner>(pPartnerToCreate);


         //Falta agregar referencias a los demas objetos, si tiene claves foraneas

            // persistimos la informacion 
            Partner mPartner = mPartnerSvc.Create(mNewPartner);

            // adaptamos y devolvemos el resultado
            return Mapper.Map<Partner, PartnerDTO>(mPartner);   
        }

        public PartnerDTO UpdatePartner(PartnerDTO pPartnerToUpdate)
        {
            // validamos parametro de entrada
            if (pPartnerToUpdate == null) throw new System.ArgumentNullException("pClientToUpdate");

            // obtencion del servicio de socios 
            IPartnerService mPartnerSvc = new PartnerService(); 

            // obtenemos el objeto a modificar
            Partner mPartnerToUpdate = mPartnerSvc.GetById(pPartnerToUpdate.Id);

            // validamos que se haya encontrado el socio
            if (mPartnerToUpdate == null) throw new System.InvalidOperationException(string.Format("Socio no encontrado", pPartnerToUpdate.Id));

           /* // obtencion del servicio de socio
            if (pPartnerToUpdate.ClientTypeId != mClientToUpdate.ClientType.Id)
            {
                // obtenemos el tipo de cliente
                IClientTypeService mClientTypeSvc = this.Resolve<IClientTypeService>();
                mClientToUpdate.ClientType = mClientTypeSvc.GetById(pClientToUpdate.ClientTypeId);
            } */
            Mapper.Map<PartnerDTO, Partner>(pPartnerToUpdate, mPartnerToUpdate);

            // actualizamos la entidad
            mPartnerSvc.Update(mPartnerToUpdate);

            return Mapper.Map<PartnerDTO>(mPartnerToUpdate);

        }

        public void DeletePartner(DeletedEntityDTO pPartnerToDelete)
        {
            // obtencion del servicio de socios
            IPartnerService mPartnerSvc = new PartnerService(); 

            // eliminamos el socio
            mPartnerSvc.Delete(pPartnerToDelete.Id);
        }
    }
}
