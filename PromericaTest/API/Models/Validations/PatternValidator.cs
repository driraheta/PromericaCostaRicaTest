using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Repositories;
using FluentValidation;

namespace API.Models.Validations
{
    public class PatternValidator : AbstractValidator<Pattern>
    {
        private readonly IMakeRepository _makeRepository;

        //public PatternValidator(IMakeRepository makeRepository)
        //{
        //    _makeRepository = makeRepository;
        //}
        
        public PatternValidator()
        {
            RuleFor(d => d.Name).NotEmpty()
                .WithMessage("El nombre del modelo no puede estar vacio");

            RuleFor(d => d.Year).Must(IsOverLimited)
                .WithMessage("El año del modelo de auto debe ser mayor que 2006");

            RuleFor(d => d.Color).NotEmpty();
            RuleFor(d => d.Doors).NotEmpty();
            //RuleFor(d => d.Make_id).Must(IsMakeExists).WithMessage("El codigo de marca de auto no existe");
        }

        private bool IsOverLimited(int year)
        {
            return year >= 2005;
        }

        //private bool IsMakeExists(int MakeId)
        //{
        //    var result = _makeRepository.GetMake(MakeId);

        //    return result != null;
        //}
    }
}
