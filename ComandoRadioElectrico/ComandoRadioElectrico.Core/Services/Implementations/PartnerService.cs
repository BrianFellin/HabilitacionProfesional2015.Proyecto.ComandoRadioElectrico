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

        public PartnerService()
        {
            this.iPartnerDAO = this.Resolve<IPartnerDAO>();
            this.iPersonDAO = this.Resolve<IPersonDAO>();
            this.iOfficerDAO = this.Resolve<IOfficerDAO>();

        }
        public void CreatePartner(PartnerDTO pPartnerToCreate)
        {
            //Se verifiac que no haya datos vacios.
            if (pPartnerToCreate.CollectDay == null)
            {
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            }
            if (pPartnerToCreate.CollectDomicile == string.Empty)
            {
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            }
            if (pPartnerToCreate.StarDate == null)
            {
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            }
            if (pPartnerToCreate.Person.DocumentNumber == string.Empty
                    || pPartnerToCreate.Person.DocumentNumber == string.Empty
                    || pPartnerToCreate.Person.DocumentTypeId == 0
                    || pPartnerToCreate.Person.Domicile == string.Empty
                    || pPartnerToCreate.Person.FirstName == string.Empty
                    || pPartnerToCreate.Person.LastName == string.Empty
                    || pPartnerToCreate.Person.Telephone == string.Empty)
            {
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            }
            if (pPartnerToCreate.ValueQuota.ToString().Length == 0)
            {
                throw new BusinessException("Campos de datos obligatorios estan vacios");
            }
            //////Se controla valores especiales//////
            if (Regex.IsMatch(pPartnerToCreate.Person.Telephone, @"^\+?\d{1,3}?[- .]?\(?(?:\d{2,3})\)?[- .]?\d\d\d[- .]?\d\d\d\d$"))
            {
                throw new InvalidFormatException("El número de teléfono no cumple con el formato");
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
                else
                {
                    if ((from p in this.iPersonDAO.GetAll() where p.DocumentNumber == pPartnerToCreate.Person.DocumentNumber select p).FirstOrDefault() != null)
                    {
                        //Como la persona existe, ya que se la ense contro por número de documento, se la asigna al socio.
                        mNewPartner.Person = (from p in this.iPersonDAO.GetAll() where p.DocumentNumber == pPartnerToCreate.Person.DocumentNumber select p).FirstOrDefault();
                    }
                    else
                    {
                        //Se crea la persona y se agrega al socio
                        this.iPersonDAO.Create(Mapper.Map<Person>(pPartnerToCreate.Person));
                    }

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

                // Se controla que no exista el socio
                foreach (Partner partner in this.iPartnerDAO.GetAll())
                {
                    if (partner.Code == mNewPartner.Code)
                    {
                        throw new PartnerException("Ya existe el socio, por favor verifique los datos");
                    }
                }
                //Le asigno el código que es número de documento del socio.
                mNewPartner.Code = mNewPartner.Person.DocumentNumber;
                //Se presiste el soción
                this.iPartnerDAO.Create(mNewPartner);
                ////// FINALIZA EL CONTROL NECESARIO PARA VERIFICAR EL SOCIO //////
            }
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
            return Mapper.Map<IList<Partner>, IList<PartnerDTO>>(this.iPartnerDAO.GetAll().ToList());
        }

        public PartnerDTO GetPartner(int pPartnerId)
        {
            return Mapper.Map<Partner, PartnerDTO>(this.iPartnerDAO.GetById(pPartnerId));
        }

        public void UpdatePartner(PartnerDTO pPartnerToUpdate)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePartner(DeletedEntityDTO pPartnerToDelete)
        {
            throw new System.NotImplementedException();
        }
    }
}
