using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;


namespace API.Models.Validations
{
    public class MakeValidator : AbstractValidator<Make>
    {
        public MakeValidator()
        {
            RuleFor(d => d.Name).NotEmpty()
                .WithMessage("El nombre de la marca no puede estar vacio");
            RuleFor(d => d.Country).NotEmpty()
                .WithMessage("El país de origen de la marca no puede estar vacio");
        }
    }
}
