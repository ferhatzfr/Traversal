using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen ilgili alanı boş bırakmayınız..!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter kullanınız..!");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Lütfen en az 5 karakter kullanınız..!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen ilgili görsel ekleyiniz..!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen ilgili alanı boş bırakmayınız..!");
           
        }
    }
}
