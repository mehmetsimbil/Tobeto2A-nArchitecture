
using Application.Features.CorporateCustomers.Commands.Create;
using Application.Features.CorporateCustomers.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;


namespace Application.Features.CorporateCustomers.Commands.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CorporateCustomer, CreateCorporateCustomerCommand>().ReverseMap();
        CreateMap<CorporateCustomer, CreatedCorporateCustomerResponse>().ReverseMap();
        CreateMap<CorporateCustomer, GetListCorporateCustomerItemDto>().ReverseMap();
        CreateMap<IPaginate<CorporateCustomer>, GetListResponse<GetListCorporateCustomerItemDto>>().ReverseMap();
    }
}
