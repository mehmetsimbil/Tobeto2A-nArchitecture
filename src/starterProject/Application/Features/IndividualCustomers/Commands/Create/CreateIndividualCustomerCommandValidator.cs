using FluentValidation;

namespace Application.Features.IndividualCustomers.Commands.Create;

public class CreateIndividualCustomerCommandValidator : AbstractValidator<CreateIndividualCustomerCommand>
{
    public CreateIndividualCustomerCommandValidator()
    {
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(c => c.Password).NotEmpty();
        RuleFor(c => c.Email).NotEmpty();
        RuleFor(c => c.NationalIdentity).NotEmpty();
    }
}