using NArchitecture.Core.Application.Dtos;

namespace Application.Features.CorporateCustomers.Queries.GetList;

public class GetListCorporateCustomerListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string CompanyName { get; set; }
    public string TaxNo { get; set; }
}