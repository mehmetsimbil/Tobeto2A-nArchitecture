using FluentValidation;

namespace Application.Features.IndividualCustomers.Commands.Update;

public class UpdateIndividualCustomerCommandValidator : AbstractValidator<UpdateIndividualCustomerCommand>
{
    public UpdateIndividualCustomerCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(c => c.Password).NotEmpty();
        RuleFor(c => c.Email).NotEmpty();
        RuleFor(c => c.NationalIdentity).NotEmpty();
    }
}