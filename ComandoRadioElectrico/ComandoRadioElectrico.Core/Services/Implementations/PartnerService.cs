using AutoMapper;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.NHibernate.Model;
using System.Collections.Generic;
using System.Linq;
using ComandoRadioElectrico.Core.DAO;
using System;
using System.Text.RegularExpressions;
using ComandoRadioElectrico.Core.Services.Interfaces;

namespace ComandoRadioElectrico.Core.Services.Implementations
{
    public class PartnerService : BaseService, IPartnerService
    {
        private IPartnerDAO iPartnerDAO;
        private IPersonDAO iPersonDAO;
        private IOfficerDAO iOfficerDAO;
        private IDocumentTypeDAO iDocumentTypeDAO;

        public PartnerService()
        {
            this.iPartnerDAO = this.Resolve<IPartnerDAO>();
            this.iPersonDAO = this.Resolve<IPersonDAO>();
            this.iOfficerDAO = this.Resolve<IOfficerDAO>();
            this.iDocumentTypeDAO = this.Resolve<IDocumentTypeDAO>();

        }
        public void CreatePartner(PartnerDTO pPartnerToCreate)
        {
            //Se verifica que no haya datos vacios.
            if (pPartnerToCreate.CollectDay == null)
            {
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            }
            else if (pPartnerToCreate.CollectDomicile == string.Empty)
            {
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            }
            else if (pPartnerToCreate.StarDate == null)
            {
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            }
            else if (pPartnerToCreate.Person.DocumentNumber == string.Empty
                    || pPartnerToCreate.Person.DocumentNumber == string.Empty
                    || pPartnerToCreate.Person.DocumentTypeId == 0
                    || pPartnerToCreate.Person.Domicile == string.Empty
                    || pPartnerToCreate.Person.FirstName == string.Empty
                    || pPartnerToCreate.Person.LastName == string.Empty
                    || pPartnerToCreate.Person.Telephone == string.Empty 
                    || pPartnerToCreate.CollectDomicile == string.Empty)
            {
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            }
            else if (pPartnerToCreate.ValueQuota.ToString() == "0")
            {
                throw new QuotaException("El valor de la cuota no puede ser 0");
            }           
            else
            {
                //Mapeamos el parametro de entrada de tipo PartnerDTO a Partner
                Partner mNewPartner = Mapper.Map<PartnerDTO, Partner>(pPartnerToCreate);

                ////// INCIA EL CONTROL NECESARIO PARA VERIFICAR LA PERSONA //////
                if (pPartnerToCreate.Person.Id != 0)
                {
                    if (this.iPersonDAO.GetById(pPartnerToCreate.Person.Id) != null)
                    {
                        //Se asigna la Persona que se localizo por Id.
                        mNewPartner.Person = this.iPersonDAO.GetById(pPartnerToCreate.Person.Id);
                    }
                }
                else if ((from p in this.iPersonDAO.GetAll() where p.DocumentNumber == pPartnerToCreate.Person.DocumentNumber select p).FirstOrDefault() != null)
                {
                    //Como la persona existe, ya que se la se encontro por número de documento, se la asigna al socio.
                    mNewPartner.Person = (from p in this.iPersonDAO.GetAll() where p.DocumentNumber == pPartnerToCreate.Person.DocumentNumber select p).FirstOrDefault();
                }
                else
                {
                    //Se crea la persona porque no se encontro en la base de datos, es decir, no existe.
                    Person mPersonToCreate = Mapper.Map<Person>(pPartnerToCreate.Person);
                    mPersonToCreate.DocumentType = this.iDocumentTypeDAO.GetById(pPartnerToCreate.Person.DocumentTypeId);
                    this.iPersonDAO.Create(mPersonToCreate);
                    mNewPartner.Person = mPersonToCreate;                 
                }
                ////// FINALIZA EL CONTROL NECESARIO PARA VERIFICAR LA PERSONA //////

                ////// COMIENZA EL CONTROL NECESARIO PARA VERIFICAR EL COBRADOR //////

                //Se asigna el cobrador.
                mNewPartner.Officer = this.iOfficerDAO.GetById(pPartnerToCreate.Officer.Id);
                if (mNewPartner.Officer == null)
                {
                    throw new NullReferenceException("No se asigno el cobrador");
                }
                ////// FINALIZA EL CONTROL NECESARIO PARA VERIFICAR EL COBRADOR //////

                ////// INCIA EL CONTROL NECESARIO PARA VERIFICAR EL SOCIO //////


                //Le asigno el código que es número de documento del socio.
                mNewPartner.Code = mNewPartner.Person.DocumentNumber;
                // Se controla que no exista el socio
                foreach (Partner partner in this.iPartnerDAO.GetAll())
                {
                    if (partner.Code == mNewPartner.Code)
                    {
                        throw new PartnerException("Ya existe un socio con ese documento, verifique los datos");
                    }
                }
                //Se presiste el soción
                this.iPartnerDAO.Create(mNewPartner);
                ////// FINALIZA EL CONTROL NECESARIO PARA VERIFICAR EL SOCIO //////
            }
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

        public PartnerDTO GetPartnerForDocumentNumber(string pDocumentNumber)
        {
            return Mapper.Map<PartnerDTO>((from p in this.iPartnerDAO.GetAll() where p.Person.DocumentNumber == pDocumentNumber select p).FirstOrDefault());
        }

        public void UpdatePartner(PartnerDTO pPartnerToUpdate)
        {
            //Se verifica que no haya datos vacios.
            if (pPartnerToUpdate.CollectDay == null)
            {
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            }
            else if (pPartnerToUpdate.CollectDomicile == string.Empty)
            {
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            }
            else if (pPartnerToUpdate.StarDate == null)
            {
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            }
            else if (pPartnerToUpdate.Person.DocumentNumber == string.Empty
                    || pPartnerToUpdate.Person.DocumentNumber == string.Empty
                    || pPartnerToUpdate.Person.DocumentTypeId == 0
                    || pPartnerToUpdate.Person.Domicile == string.Empty
                    || pPartnerToUpdate.Person.FirstName == string.Empty
                    || pPartnerToUpdate.Person.LastName == string.Empty
                    || pPartnerToUpdate.Person.Telephone == string.Empty
                    || pPartnerToUpdate.CollectDomicile == string.Empty)
            {
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            }

            else if (pPartnerToUpdate.ValueQuota.ToString() == "0")
            {
                throw new QuotaException("El valor de la cuota no puede ser 0");
            }
            else
            {
                //Obtengo el socio original para modificacrle los datos
                Partner mNewPartnerToUpdate = Mapper.Map<Partner>(this.iPartnerDAO.GetById(pPartnerToUpdate.Id));                
                ////// MODIFICACIÓN DE LA PERSONA //////
                if (mNewPartnerToUpdate.Person.DocumentNumber != pPartnerToUpdate.Person.DocumentNumber)
                {
                    mNewPartnerToUpdate.Person.DocumentNumber = pPartnerToUpdate.Person.DocumentNumber;
                    mNewPartnerToUpdate.Code = pPartnerToUpdate.Person.DocumentNumber;
                    // Se controla que no exista el socio
                    if ((from p in this.iPartnerDAO.GetAll() where p.Code==mNewPartnerToUpdate.Code select p).ToList().Count>0)
                    {
                        throw new PartnerException("Ya existe un socio con ese documento, verifique los datos");
                    }
                }
                mNewPartnerToUpdate.Person.DocumentNumber = pPartnerToUpdate.Person.DocumentNumber;
                mNewPartnerToUpdate.Person.DocumentType = this.iDocumentTypeDAO.GetById(pPartnerToUpdate.Person.DocumentTypeId);
                mNewPartnerToUpdate.Person.Domicile = pPartnerToUpdate.Person.Domicile;
                mNewPartnerToUpdate.Person.FirstName = pPartnerToUpdate.Person.FirstName;
                mNewPartnerToUpdate.Person.LastName = pPartnerToUpdate.Person.LastName;
                mNewPartnerToUpdate.Person.Telephone = pPartnerToUpdate.Person.Telephone;
                this.iPersonDAO.Update(mNewPartnerToUpdate.Person);
                ////// MODIFICACIÓN DE LA PERSONA //////
                ////// MODIFICACIÓN DEL COBRADOR //////
                mNewPartnerToUpdate.Officer = this.iOfficerDAO.GetById(pPartnerToUpdate.Officer.Id);
                if (mNewPartnerToUpdate.Officer == null)
                {
                    throw new NullReferenceException("No se asigno el cobrador");
                }
                ////// MODIFICACIÓN DEL COBRADOR //////
                /////// MODIFICACIÓN DEL SOCIO //////
                mNewPartnerToUpdate.CollectDay = pPartnerToUpdate.CollectDay;
                mNewPartnerToUpdate.CollectDomicile = pPartnerToUpdate.CollectDomicile;
                mNewPartnerToUpdate.ValueQuota = pPartnerToUpdate.ValueQuota;
                //Modifico el socio                              
                this.iPartnerDAO.Update(mNewPartnerToUpdate);
            }
        }

        /// <summary>
        /// Este método da de baja un socio.
        /// </summary>
        /// <param name="pPartnerId"></param>
        public void DeletePartner(int pPartnerId)
        {
            try
            {
                // Se busca el socio.
                Partner pPertnerToDelete= this.iPartnerDAO.GetById(pPartnerId);
                // Se elimina el socio "acá se hace la baja lógiga poniendo la fecha de baja"
                pPertnerToDelete.FinishDate = DateTime.Today;
                //Finalmente se guarda el socio.
                this.iPartnerDAO.Update(pPertnerToDelete);
            }
            catch(Exception)
            {
                throw new PartnerException("No  se pudo eliminar el socio");
            }
            
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
