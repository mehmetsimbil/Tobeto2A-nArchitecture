using Application.Features.IndividualCustomers.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using MediatR;

namespace Application.Features.IndividualCustomers.Commands.Update;

public class UpdateIndividualCustomerCommand : IRequest<UpdatedIndividualCustomerResponse>, ICacheRemoverRequest, ILoggableRequest
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string NationalIdentity { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetIndividualCustomers"];

    public class UpdateIndividualCustomerCommandHandler : IRequestHandler<UpdateIndividualCustomerCommand, UpdatedIndividualCustomerResponse>
    {
        private readonly IMapper _mapper;
        private readonly IIndividualCustomerRepository _individualCustomerRepository;
        private readonly IndividualCustomerBusinessRules _individualCustomerBusinessRules;

        public UpdateIndividualCustomerCommandHandler(IMapper mapper, IIndividualCustomerRepository individualCustomerRepository,
                                         IndividualCustomerBusinessRules individualCustomerBusinessRules)
        {
            _mapper = mapper;
            _individualCustomerRepository = individualCustomerRepository;
            _individualCustomerBusinessRules = individualCustomerBusinessRules;
        }

        public async Task<UpdatedIndividualCustomerResponse> Handle(UpdateIndividualCustomerCommand request, CancellationToken cancellationToken)
        {
            IndividualCustomer? individualCustomer = await _individualCustomerRepository.GetAsync(predicate: ic => ic.Id == request.Id, cancellationToken: cancellationToken);
            await _individualCustomerBusinessRules.IndividualCustomerShouldExistWhenSelected(individualCustomer);
            individualCustomer = _mapper.Map(request, individualCustomer);

            await _individualCustomerRepository.UpdateAsync(individualCustomer!);

            UpdatedIndividualCustomerResponse response = _mapper.Map<UpdatedIndividualCustomerResponse>(individualCustomer);
            return response;
        }
    }
}