using ComandoRadioElectrico.Core.NHibernate.Model;
using ComandoRadioElectrico.Core.DTO;
using AutoMapper;


namespace ComandoRadioElectrico.Core.Utils
{
    public static class MappingHelper
    {
        public static void CreateMaps()
        {            
            //Registro de los Mapeos            
            Mapper.CreateMap<Partner, PartnerDTO>();
            Mapper.CreateMap<PartnerDTO, Partner>();
            Mapper.CreateMap<DocumentType, DocumentTypeDTO>();            
            Mapper.CreateMap<Person, PersonDTO>();
            Mapper.CreateMap<PersonDTO, Person>();
            Mapper.CreateMap<AccountantAccountDTO, AccountantAccount>();
            Mapper.CreateMap<AccountantAccount, AccountantAccountDTO>();
            Mapper.CreateMap<AccountType, AccountTypeDTO>();
            Mapper.CreateMap<Officer, OfficerDTO>();
            Mapper.CreateMap<OfficerDTO, Officer>();
            Mapper.CreateMap<DocumentTypeDTO, DocumentType>();
            Mapper.CreateMap<QuotaDTO, Quota>();  
            Mapper.CreateMap<FindEntityResult<AccountantAccount>,FindEntityResultDTO<AccountantAccountDTO>>();
            Mapper.CreateMap<FindEntityResult<Partner>, FindEntityResultDTO<PartnerDTO>>();
        }      
    }
}
