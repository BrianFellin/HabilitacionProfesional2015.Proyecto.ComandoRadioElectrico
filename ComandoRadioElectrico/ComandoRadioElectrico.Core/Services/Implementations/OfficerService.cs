using AutoMapper;
using ComandoRadioElectrico.Core.DAO;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.Model;
using ComandoRadioElectrico.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComandoRadioElectrico.Core.Services.Implementations
{
    public class OfficerService : BaseService, IOfficerService
    {
        private IOfficerDAO iOfficerDAO;        
        private IDocumentTypeDAO iDocumentTypeDAO;

        public OfficerService()
        {
            this.iOfficerDAO = this.Resolve<IOfficerDAO>();            
            this.iDocumentTypeDAO = this.Resolve<IDocumentTypeDAO>();
        }

        public void CreateOfficer(OfficerDTO pOfficerToCreate)
        {
            //Validamos los campos del parametro de entrada
            if (pOfficerToCreate.FirstName == string.Empty                                  
                 || pOfficerToCreate.LastName == null
                 || pOfficerToCreate.DocumentTypeId == 0
                 || pOfficerToCreate.DocumentNumber == null)
                throw new BusinessException("Campos de datos obligatorios estan vacios");

            // creamos el objeto cobrador
            Officer mNewOfficer = Mapper.Map<OfficerDTO, Officer>(pOfficerToCreate);
                  
            //validamos que el dni sea unico y no halla otro cobrador con el mismo dni
            if ((from a in this.iOfficerDAO.GetAll() where a.DocumentNumber == pOfficerToCreate.DocumentNumber select a).Count() > 0)
            {
                throw new BusinessException("Ya existe un cobrador con el codigo ingresado, ingrese otro");
            }
            //Obtengo el tipo de documento
            mNewOfficer.DocumentType = this.iDocumentTypeDAO.GetById(pOfficerToCreate.DocumentTypeId);

            // persistimos la informacion 
            this.iOfficerDAO.Create(mNewOfficer);
        }

        public void UpdateOfficer(OfficerDTO pOfficerToUpdate)
        {
            //validamos parametro de entrada
            if (pOfficerToUpdate == null) throw new System.ArgumentNullException("pOfficerToUpdate");

            //Validamos los campos del parametro de entrada
            if (pOfficerToUpdate.FirstName == string.Empty
                 || pOfficerToUpdate.LastName == null
                 || pOfficerToUpdate.DocumentTypeId == 0
                 || pOfficerToUpdate.DocumentNumber == null)
                throw new BusinessException("Campos de datos obligatorios estan vacios");

            // obtenemos el objeto a modificar
            Officer mOfficerToUpdate = this.iOfficerDAO.GetById(pOfficerToUpdate.Id);

            // validamos que se haya encontrado el cobrador
            if (mOfficerToUpdate == null) throw new System.InvalidOperationException(string.Format("Cobrador no encontrado", pOfficerToUpdate.Id));
            
            //validamos que el dni sea unico y no halla otro cobrador con el mismo dni
            if ((from a in this.iOfficerDAO.GetAll() where a.DocumentNumber == pOfficerToUpdate.DocumentNumber & a.Id != pOfficerToUpdate.Id select a).Count() > 0)
            {
                throw new BusinessException("Ya existe un cobrador con el dni ingresado, ingrese otro");
            }
            //Si cambio el tipo de documento, se actualiza
            if (pOfficerToUpdate.DocumentTypeId != mOfficerToUpdate.DocumentType.Id )
            {
                mOfficerToUpdate.DocumentType = this.iDocumentTypeDAO.GetById(pOfficerToUpdate.DocumentTypeId);
            }
            Mapper.Map<OfficerDTO, Officer>(pOfficerToUpdate, mOfficerToUpdate);

            // actualizamos la entidad
            this.iOfficerDAO.Update(mOfficerToUpdate);
        }

        public void DeleteOfficer(OfficerDTO pOfficerToDelete)
        {
            //validamos que el Id este en el rango correcto
            if (pOfficerToDelete.Id < -1) throw new System.ArgumentOutOfRangeException("pOfficerToDelete");

            //Se establece la fecha de baja
            pOfficerToDelete.FinishDate = DateTime.Today;

            Officer mOfficerToDelete = Mapper.Map<OfficerDTO, Officer>(pOfficerToDelete);

            // se da de baja el cobrador
            this.iOfficerDAO.Update(mOfficerToDelete);
        }

        public FindEntityResultDTO<OfficerDTO> FindOfficer(FindEntityDTO pCriteria)
        {
            return Mapper.Map<FindEntityResult<Officer>, FindEntityResultDTO<OfficerDTO>>(this.iOfficerDAO.Find(new FindEntityParams
            {
                QuickSearchText = pCriteria.QuickSearchText,
                RecordCount = pCriteria.RecordCount,
                OrderByDirectionDescending = pCriteria.OrderByDirectionDescending,
                SkipRecordCount = pCriteria.SkipRecordCount
            }));
        }

        public IEnumerable<OfficerDTO> GetAll()
        {
            return Mapper.Map<IList<Officer>, IList<OfficerDTO>>(this.iOfficerDAO.GetAll().ToList());
        }
    }
}
