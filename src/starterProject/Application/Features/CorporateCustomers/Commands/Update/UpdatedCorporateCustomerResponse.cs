using NArchitecture.Core.Application.Responses;

namespace Application.Features.CorporateCustomers.Commands.Update;

public class UpdatedCorporateCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
}