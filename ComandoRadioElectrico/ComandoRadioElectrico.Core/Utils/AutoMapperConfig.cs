using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ComandoRadioElectrico.Core.NHibernate.Model;
using ComandoRadioElectrico.Core.DTO;

namespace ComandoRadioElectrico.Core.Utils
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.CreateMap<Partner, PartnerDTO>();
            AutoMapper.Mapper.CreateMap<PartnerDTO, Partner>();
            AutoMapper.Mapper.CreateMap<Officer, OfficerDTO>();
            AutoMapper.Mapper.CreateMap<OfficerDTO, Officer>();
            AutoMapper.Mapper.CreateMap<DocumentType, DocumentTypeDTO>();
            AutoMapper.Mapper.CreateMap<Person, PersonDTO>();
            AutoMapper.Mapper.CreateMap<PersonDTO, Person>();
            AutoMapper.Mapper.CreateMap<DocumentTypeDTO, DocumentType>();
        }      
    }
}
