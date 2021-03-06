﻿using AutoMapper;
using ComandoRadioElectrico.Core.DAO;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.Core.Model;
using ComandoRadioElectrico.Core.Services.Interfaces;
using ComandoRadioElectrico.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComandoRadioElectrico.Core.Services.Implementations
{
    public class QuotaService : BaseService, IQuotaService
    {
        private IQuotaDAO iQuotaDAO;
        private IGeneratedPeriodDAO iGeneratedPeriodDAO;
        private IPartnerDAO iPartnerDAO;

        public QuotaService()
        {
            this.iQuotaDAO = this.Resolve<IQuotaDAO>();
            this.iGeneratedPeriodDAO = this.Resolve<IGeneratedPeriodDAO>();
            this.iPartnerDAO = this.Resolve<IPartnerDAO>();
        }

        public IList<QuotaDTO> GetQuotasOfPartner(int pIdPartner)
        {
            //Se verifica que el parametro sea valido
            if (pIdPartner < 1) throw new ArgumentOutOfRangeException("El id de socio no esta en el rango permitido");

            return  Mapper.Map<IList<Quota>, IList<QuotaDTO>>(this.iQuotaDAO.GetAll().Where(p => p.Partner.Id == pIdPartner).ToList());            
        }

        public void Pay(int pIdQuotaToPay)
        {
            //Se verifica que el parametro sea valido
            if (pIdQuotaToPay < 1) throw new ArgumentOutOfRangeException("El id de cuota no esta en el rango permitido");

            //Obtengo la cuota a pagar
            Quota mQuotaToPay = this.iQuotaDAO.GetById(pIdQuotaToPay);

            //Se valida que se encontró la cuota
            if (mQuotaToPay == null) throw new System.InvalidOperationException(string.Format("Cuota no encontrada", pIdQuotaToPay));

            //Se valida que la cuota ya no se encuentre pagada
            if (mQuotaToPay.IsPaid) throw new System.InvalidOperationException(string.Format("La cuota ya esta paga", pIdQuotaToPay));

            //Cambio la cuota a Pagada
            mQuotaToPay.IsPaid = true;

            //Actualizo los datos
            this.iQuotaDAO.Update(mQuotaToPay);
        }

        public void GenerateQuotas(MonthPeriod pMonth, int pYear)
        {               
            //Se valida que ya no exista otro periodo igual
            if ((from p in this.iGeneratedPeriodDAO.GetAll() where p.Month == pMonth.ToString() & p.Year == pYear select p).Count() > 0)
                throw new BusinessException("El período que se desea generar ya ha sido generado");
            //Genero las cuotas
            this.iQuotaDAO.GenerateQuotas(pMonth, pYear);
        }
    }
}
