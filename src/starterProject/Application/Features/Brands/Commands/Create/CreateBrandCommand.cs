using Application.Features.Brands.Commands.Rules;
using Application.Features.Brands.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Pipelines.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;
public class CreateBrandCommand : IRequest<CreatedBrandResponse> , ISecuredRequest
{
    public string Name { get; set; }
    public string LogoUrl { get; set; }
    public bool Premium { get; set; }
    public double Rating { get; set; }

    // ||
    public string[] Roles => new string[] {BrandsOperationClaims.Write,BrandsOperationClaims.Create};

    //inner class

    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;
        private readonly BrandBusinessRules _brandBusinessRules;
        public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
            _brandBusinessRules = brandBusinessRules;
        }

        public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            await _brandBusinessRules.CarShouldNotExistsWithSomeName(request.Name);
            Brand brand = _mapper.Map<Brand>(request);
            Brand addedBrand = await _brandRepository.AddAsync(brand);
            CreatedBrandResponse createdBrandResponse = _mapper.Map<CreatedBrandResponse>(addedBrand);
            return createdBrandResponse;
        }
    }
}
