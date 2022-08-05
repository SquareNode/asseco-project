using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using AutoMapper;
using projekat.Database.Entities;

namespace projekat.Mappings
{
    public class AutoMappingMappingProfile : Profile 
    {
        public AutoMappingMappingProfile()
        {
            CreateMap<TransactionEntity, TransactionWithSplits>()
                .ForMember(p => p.Id, opts => opts.MapFrom(s => s.id))
                .ForMember(p => p.Splits, opts => opts.MapFrom(s => s.split));

            CreateMap<SplitEntity, SingleCategorySplit>().ForMember(p => p.Amount, opts => opts.MapFrom(s => s.Amount))
                .ForMember(p => p.Catcode, opts => opts.MapFrom(s => s.CatCode));

        }
    }
}
