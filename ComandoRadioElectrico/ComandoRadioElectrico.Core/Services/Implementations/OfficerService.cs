using AutoMapper;
using ComandoRadioElectrico.Core.DAO;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.NHibernate.Model;
using ComandoRadioElectrico.Core.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ComandoRadioElectrico.Core.Services.Implementations
{
    public class OfficerService : BaseService, IOfficerService
    {
        private IOfficerDAO iOfficerDAO;

        public OfficerService()
        {
            this.iOfficerDAO = this.Resolve<IOfficerDAO>();
        }
        public OfficerDTO GetOfficer(int pOfficerId)
        {                                   
            Officer mOfficer = this.iOfficerDAO.GetById(pOfficerId);
            if (mOfficer == null)
                throw new System.InvalidOperationException(string.Format("Cobrador no encontrado", pOfficerId));
            return Mapper.Map<OfficerDTO>(mOfficer);
        }


        // Los metodos siguientes no se implementaran ya que no son necesarios.
        
        public void CreateOfficer(OfficerDTO pOfficerToCreate)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateOfficer(OfficerDTO pOfficerToUpdate)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteOfficer(DeletedEntityDTO pOfficerToDelete)
        {
            throw new System.NotImplementedException();
        }


        public IList<OfficerDTO> GetAll()
        {
            return Mapper.Map<IList<Officer>, IList<OfficerDTO>>(this.iOfficerDAO.GetAll().ToList());
        }
    }
}
