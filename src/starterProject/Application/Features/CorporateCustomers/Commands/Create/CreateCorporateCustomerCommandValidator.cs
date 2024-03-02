using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CorporateCustomers.Commands.Create;
public class CreateCorporateCustomerCommandValidator: AbstractValidator<CreateCorporateCustomerCommand>
{
    public CreateCorporateCustomerCommandValidator()
    {
        RuleFor(i => i.CompanyName).NotEmpty().NotNull().MinimumLength(2);
    }
}
