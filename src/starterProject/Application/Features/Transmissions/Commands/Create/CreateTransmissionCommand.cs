using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;


namespace Application.Features.Transmissions.Commands.Create;
public class CreateTransmissionCommand : IRequest<CreatedTransmissionResponse>
{
    public string Name { get; set; }

    public class CreateTransmissionCommandHandler : IRequestHandler<CreateTransmissionCommand, CreatedTransmissionResponse>
    {
        private readonly IMapper _mapper;
        private readonly ITransmissionRepository _transmissionRepository;

        public CreateTransmissionCommandHandler(IMapper mapper, ITransmissionRepository transmissionRepository)
        {
            _mapper = mapper;
            _transmissionRepository = transmissionRepository;
        }

        public async Task<CreatedTransmissionResponse> Handle(CreateTransmissionCommand request, CancellationToken cancellationToken)
        {
            Transmission transmission = _mapper.Map<Transmission>(request);
            Transmission addedTransmission = await _transmissionRepository.AddAsync(transmission);
            CreatedTransmissionResponse createdTransmissionResponse = _mapper.Map<CreatedTransmissionResponse>(addedTransmission);
            return createdTransmissionResponse;
        }
    }
}
