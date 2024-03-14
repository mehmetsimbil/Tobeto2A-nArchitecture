using FluentValidation;

namespace Application.Features.CorporateCustomers.Commands.Create;

public class CreateCorporateCustomerCommandValidator : AbstractValidator<CreateCorporateCustomerCommand>
{
    public CreateCorporateCustomerCommandValidator()
    {
        RuleFor(c => c.Email).NotEmpty();
        RuleFor(c => c.Password).NotEmpty();
        RuleFor(c => c.CompanyName).NotEmpty();
        RuleFor(c => c.TaxNo).NotEmpty();
    }
}