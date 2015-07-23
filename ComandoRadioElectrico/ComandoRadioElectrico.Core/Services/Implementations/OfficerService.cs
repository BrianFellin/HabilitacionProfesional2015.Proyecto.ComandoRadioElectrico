using AutoMapper;
using ComandoRadioElectrico.Core.DAO;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.NHibernate.Model;
using ComandoRadioElectrico.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComandoRadioElectrico.Core.Services.Implementations
{
    public class OfficerService : BaseService, IOfficerService
    {
        private IOfficerDAO iOfficerDAO;
        private IPersonDAO iPersonDAO;
        private IDocumentTypeDAO iDocumentTypeDAO;

        public OfficerService()
        {
            this.iOfficerDAO = this.Resolve<IOfficerDAO>();
            this.iPersonDAO = this.Resolve<IPersonDAO>();
            this.iDocumentTypeDAO = this.Resolve<IDocumentTypeDAO>();
        }

        public void CreateOfficer(OfficerDTO pOfficerToCreate)
        {
            //Validamos los campos del parametro de entrada
            if (pOfficerToCreate.Code == string.Empty                                  
                 || pOfficerToCreate.StarDate == null)
                throw new BusinessException("Campos de datos obligatorios estan vacios");

            // creamos el objeto cobrador
            Officer mNewOfficer = Mapper.Map<OfficerDTO, Officer>(pOfficerToCreate);


             //Obtenemos la persona del cobrador
             mNewOfficer.Person = this.iPersonDAO.GetById(pOfficerToCreate.Person.Id);
             //Si no se encontro la persona, se crea y luego se la asigna al cobrador
             if (mNewOfficer.Person == null)
             {
                 Person mNewPerson = Mapper.Map<PersonDTO, Person>(pOfficerToCreate.Person);
                 mNewPerson.DocumentType = this.iDocumentTypeDAO.GetById(pOfficerToCreate.Person.DocumentTypeId);
                 mNewOfficer.Person = this.iPersonDAO.GetById(this.iPersonDAO.Create(mNewPerson));
             }
        
            //validamos que el codigo sea unico y no halla otro cobrador con el mismo codigo
            if ((from a in this.iOfficerDAO.GetAll() where a.Code == pOfficerToCreate.Code select a).Count() > 0)
            {
                throw new BusinessException("Ya existe un cobrador con el codigo ingresado, ingrese otro");
            }

            // persistimos la informacion 
            this.iOfficerDAO.Create(mNewOfficer);
        }

        public void UpdateOfficer(OfficerDTO pOfficerToUpdate)
        {
            //validamos parametro de entrada
            if (pOfficerToUpdate == null) throw new System.ArgumentNullException("pOfficerToUpdate");

            //Validamos los campos del parametro de entrada
            if (pOfficerToUpdate.Code == string.Empty
                 || pOfficerToUpdate.StarDate == null)
                throw new BusinessException("Campos de datos obligatorios estan vacios");

            // obtenemos el objeto a modificar
            Officer mOfficerToUpdate = this.iOfficerDAO.GetById(pOfficerToUpdate.Id);

            // validamos que se haya encontrado el cobrador
            if (mOfficerToUpdate == null) throw new System.InvalidOperationException(string.Format("Cobrador no encontrado", pOfficerToUpdate.Id));
            
            //validamos que el codigo sea unico y no halla otro cobrador con el mismo codigo
            if ((from a in this.iOfficerDAO.GetAll() where a.Code == pOfficerToUpdate.Code & a.Id != pOfficerToUpdate.Id select a).Count() > 0)
            {
                throw new BusinessException("Ya existe un cobrador con el codigo ingresado, ingrese otro");
            }
            if (mOfficerToUpdate.Person.DocumentNumber != pOfficerToUpdate.Person.DocumentNumber)
            {
                mOfficerToUpdate.Person.DocumentNumber = pOfficerToUpdate.Person.DocumentNumber;
                // Se controla que no exista el cobrador
                if ((from p in this.iOfficerDAO.GetAll() where p.Person.DocumentNumber == mOfficerToUpdate.Person.DocumentNumber & p.Id != pOfficerToUpdate.Id select p).ToList().Count > 0)
                {
                    throw new PartnerException("Ya existe una persona con ese documento, verifique los datos");
                }
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
