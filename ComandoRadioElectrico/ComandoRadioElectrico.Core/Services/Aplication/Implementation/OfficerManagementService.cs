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
    public class OfficerManagementService : BaseService, IOfficerManagementService
    {
        public OfficerDTO GetOfficer(int pOfficerId)
        {             
            // obtencion del servicio del cobrador
            IOfficerService mOfficerService = this.Resolve<IOfficerService>();            
            Officer mOfficer = mOfficerService.GetById(pOfficerId);
            if (mOfficer == null)
                throw new System.InvalidOperationException(string.Format("Cobrador no encontrado", pOfficerId));
            return Mapper.Map<OfficerDTO>(mOfficer);
        }


        // Los metodos siguientes no se implementaran ya que no son necesarios.
        
        public OfficerDTO CreateOfficer(OfficerDTO pOfficerToCreate)
        {
            throw new System.NotImplementedException();
        }

        public OfficerDTO UpdateOfficer(OfficerDTO pOfficerToUpdate)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteOfficer(DeletedEntityDTO pOfficerToDelete)
        {
            throw new System.NotImplementedException();
        }


        public IList<OfficerDTO> GetAll()
        {
            // obtencion del servicio de tipo de documento
            IOfficerService mOfficerService = this.Resolve<IOfficerService>();
            // Devolución de los Socios, el maper los convierte del tipo Officer a OfficerDTO (tipo que maneja el .Core)
            return Mapper.Map<IList<Officer>, IList<OfficerDTO>>(mOfficerService.GetAll().ToList());
        }
    }
}
