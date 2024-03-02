
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;


namespace Application.Features.CorporateCustomers.Queries.GetList;
public class GetListCorporateCustomerQuery : IRequest<GetListResponse<GetListCorporateCustomerItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListCorporateCustomerQueryHandler : IRequestHandler<GetListCorporateCustomerQuery, GetListResponse<GetListCorporateCustomerItemDto>>
    {
        private readonly ICorporateCustomerRepository _corporateCustomerRepository;
        private readonly IMapper _mapper;

        public GetListCorporateCustomerQueryHandler(ICorporateCustomerRepository corporateCustomerRepository, IMapper mapper)
        {
            _corporateCustomerRepository = corporateCustomerRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListCorporateCustomerItemDto>> Handle(GetListCorporateCustomerQuery request, CancellationToken cancellationToken)
        {
            IPaginate<CorporateCustomer> corporateCustomers = await _corporateCustomerRepository.GetListAsync(index: request.PageRequest.PageIndex, size: request.PageRequest.PageSize);

            GetListResponse<GetListCorporateCustomerItemDto> response = _mapper.Map<GetListResponse<GetListCorporateCustomerItemDto>>(corporateCustomers);
            return response;
        }
    }
}
