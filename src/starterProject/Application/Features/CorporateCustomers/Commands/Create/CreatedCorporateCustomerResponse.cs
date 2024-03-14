using NArchitecture.Core.Application.Responses;

namespace Application.Features.CorporateCustomers.Commands.Create;

public class CreatedCorporateCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
}