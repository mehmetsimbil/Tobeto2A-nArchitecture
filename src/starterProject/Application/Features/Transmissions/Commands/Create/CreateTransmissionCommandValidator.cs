using Application.Features.Fuels.Commands.Create;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Transmissions.Commands.Create;
public class CreateTransmissionCommandValidator : AbstractValidator<CreateTransmissionCommand>
{
    public CreateTransmissionCommandValidator()
    {
        RuleFor(i => i.Name).NotEmpty().NotNull().MinimumLength(2);
    }
}
