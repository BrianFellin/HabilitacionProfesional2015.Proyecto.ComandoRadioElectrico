using AutoMapper;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.Model;
using System.Collections.Generic;
using System.Linq;
using ComandoRadioElectrico.Core.DAO;
using System;
using ComandoRadioElectrico.Core.Services.Interfaces;

namespace ComandoRadioElectrico.Core.Services.Implementations
{
    public class PartnerService : BaseService, IPartnerService
    {
        private IPartnerDAO iPartnerDAO;        
        private IOfficerDAO iOfficerDAO;
        private IDocumentTypeDAO iDocumentTypeDAO;

        public PartnerService()
        {
            this.iPartnerDAO = this.Resolve<IPartnerDAO>();            
            this.iOfficerDAO = this.Resolve<IOfficerDAO>();
            this.iDocumentTypeDAO = this.Resolve<IDocumentTypeDAO>();

        }
        public void CreatePartner(PartnerDTO pPartnerToCreate)
        {
            //Se verifica que no haya datos vacios.
            if (pPartnerToCreate.CollectDay == null
                || pPartnerToCreate.CollectDomicile == string.Empty
                || pPartnerToCreate.StarDate == null                          
                || pPartnerToCreate.DocumentNumber == string.Empty
                || pPartnerToCreate.DocumentTypeId == 0
                || pPartnerToCreate.Domicile == string.Empty
                || pPartnerToCreate.FirstName == string.Empty
                || pPartnerToCreate.LastName == string.Empty
                || pPartnerToCreate.Telephone == string.Empty 
                || pPartnerToCreate.CollectDomicile == string.Empty)            
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            
             //Mapeamos el parametro de entrada de tipo PartnerDTO a Partner
             Partner mNewPartner = Mapper.Map<PartnerDTO, Partner>(pPartnerToCreate);

             //Le asigno al contador del regimen de cuotas el mismo valor del regimen de cuotas
             mNewPartner.QuotaCounter = mNewPartner.QuotaRegime;

             //validamos que el dni sea unico y no halla otro socio con el mismo dni
             if ((from a in this.iPartnerDAO.GetAll() where a.DocumentNumber == pPartnerToCreate.DocumentNumber select a).Count() > 0)
             {
                 throw new BusinessException("Ya existe un socio con el codigo ingresado, ingrese otro");
             }

             //Obtenemos el tipo de documento del socio
             mNewPartner.DocumentType = this.iDocumentTypeDAO.GetById(pPartnerToCreate.DocumentTypeId);

             //Obtenemos el cobrador asignado al socio
             mNewPartner.Officer = this.iOfficerDAO.GetById(pPartnerToCreate.Officer.Id);
             
            // persistimos la informacion 
             this.iPartnerDAO.Create(mNewPartner);                
        }
        

        public IList<PartnerDTO> GetAll()
        {
            IList<PartnerDTO> listToReturn = Mapper.Map<IList<PartnerDTO>>((this.iPartnerDAO.GetAll().ToList()));
            return (from p in listToReturn where p.FinishDate == null select p).ToList();
        }

        public PartnerDTO GetPartner(int pPartnerId)
        {
            return Mapper.Map<Partner, PartnerDTO>(this.iPartnerDAO.GetById(pPartnerId));
        }

        public void UpdatePartner(PartnerDTO pPartnerToUpdate)
        {
             //Se verifica que no haya datos vacios.
            if (pPartnerToUpdate.CollectDay == null
                || pPartnerToUpdate.CollectDomicile == string.Empty
                || pPartnerToUpdate.StarDate == null                          
                || pPartnerToUpdate.DocumentNumber == string.Empty
                || pPartnerToUpdate.DocumentTypeId == 0
                || pPartnerToUpdate.Domicile == string.Empty
                || pPartnerToUpdate.FirstName == string.Empty
                || pPartnerToUpdate.LastName == string.Empty
                || pPartnerToUpdate.Telephone == string.Empty 
                || pPartnerToUpdate.CollectDomicile == string.Empty)            
                throw new BusinessException("Campos de datos obligatorios estan vacios");

           //Obtengo el socio original para modificarle los datos
           Partner mPartnerToUpdate = Mapper.Map<Partner>(this.iPartnerDAO.GetById(pPartnerToUpdate.Id));
        
            if (mPartnerToUpdate.QuotaRegime != pPartnerToUpdate.QuotaRegime)
            {
                mPartnerToUpdate.QuotaRegime = pPartnerToUpdate.QuotaRegime;
                mPartnerToUpdate.QuotaCounter = pPartnerToUpdate.QuotaRegime;
            }
           // validamos que se haya encontrado el cobrador
           if (mPartnerToUpdate == null) throw new System.InvalidOperationException(string.Format("Socio no encontrado", pPartnerToUpdate.Id));

           //validamos que el dni sea unico y no halla otro socio con el mismo dni
           if ((from a in this.iPartnerDAO.GetAll() where a.DocumentNumber == pPartnerToUpdate.DocumentNumber & a.Id != pPartnerToUpdate.Id select a).Count() > 0)
           {
               throw new BusinessException("Ya existe un socio con el dni ingresado, ingrese otro");
           }
           //Si cambio el tipo de documento, se actualiza
           if (pPartnerToUpdate.DocumentTypeId != mPartnerToUpdate.DocumentType.Id)
           {
               mPartnerToUpdate.DocumentType = this.iDocumentTypeDAO.GetById(pPartnerToUpdate.DocumentTypeId);
           }
           //Si cambio el cobrador, se actualiza
           if (pPartnerToUpdate.Officer.Id != mPartnerToUpdate.Officer.Id)
           {
               mPartnerToUpdate.Officer = this.iOfficerDAO.GetById(pPartnerToUpdate.Officer.Id);
           }
           Mapper.Map<PartnerDTO, Partner>(pPartnerToUpdate, mPartnerToUpdate);

           // actualizamos la entidad
           this.iPartnerDAO.Update(mPartnerToUpdate);     
            
        }

        /// <summary>
        /// Este método da de baja un socio.
        /// </summary>
        /// <param name="pPartnerId"></param>
        public void DeletePartner(int pPartnerId)
        {         
             // Se busca el socio.
             Partner pPertnerToDelete= this.iPartnerDAO.GetById(pPartnerId);
             // Se elimina el socio "acá se hace la baja lógiga poniendo la fecha de baja"
             pPertnerToDelete.FinishDate = DateTime.Today;
             //Finalmente se guarda el socio.
             this.iPartnerDAO.Update(pPertnerToDelete);            
        }

        public FindEntityResultDTO<PartnerDTO> FindPartner(FindEntityDTO pCriteria)
        {
            return Mapper.Map<FindEntityResult<Partner>, FindEntityResultDTO<PartnerDTO>>(this.iPartnerDAO.Find(new FindEntityParams
            {
                QuickSearchText = pCriteria.QuickSearchText,
                RecordCount = pCriteria.RecordCount,
                OrderByDirectionDescending = pCriteria.OrderByDirectionDescending,
                SkipRecordCount = pCriteria.SkipRecordCount
            }));
        }
    }
}
