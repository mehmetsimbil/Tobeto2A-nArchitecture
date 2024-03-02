using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Commands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CorporateCustomers.Commands.Create;
public class CreateCorporateCustomerCommand : IRequest<CreatedCorporateCustomerResponse>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }

    public class CreateCorporateCustomerCommandHandler : IRequestHandler<CreateCorporateCustomerCommand, CreatedCorporateCustomerResponse>
    {
        private readonly ICorporateCustomerRepository _corporateCustomerRepository;
        private readonly IMapper _mapper;

        public CreateCorporateCustomerCommandHandler(ICorporateCustomerRepository corporateCustomerRepository, IMapper mapper)
        {
            _corporateCustomerRepository = corporateCustomerRepository;
            _mapper = mapper;
        }

        public async Task<CreatedCorporateCustomerResponse> Handle(CreateCorporateCustomerCommand request, CancellationToken cancellationToken)
        {
            
            CorporateCustomer corporateCustomer = _mapper.Map<CorporateCustomer>(request);
            CorporateCustomer addedCorporateCustomer = await _corporateCustomerRepository.AddAsync(corporateCustomer);
            CreatedCorporateCustomerResponse createdCorporateCustomerResponse = _mapper.Map<CreatedCorporateCustomerResponse>(addedCorporateCustomer);
            return createdCorporateCustomerResponse;
        }
    }
}
