using NArchitecture.Core.Application.Responses;

namespace Application.Features.IndividualCustomers.Commands.Update;

public class UpdatedIndividualCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string NationalIdentity { get; set; }
}