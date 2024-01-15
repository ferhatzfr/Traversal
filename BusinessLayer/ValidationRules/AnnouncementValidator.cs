using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDtos>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Boş geçilemez...");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("En az 5 karakter içermelidir...");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("En fazla 50 karakter içermelidir...");

            RuleFor(x => x.Content).NotEmpty().WithMessage("Boş geçilemez...");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("En az 20 karakter içermelidir...");
            RuleFor(x => x.Content).MaximumLength(200).WithMessage("En fazla 50 karakter içermelidir...");
        }
    }
}
