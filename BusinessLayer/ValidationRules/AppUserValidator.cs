using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserValidator : AbstractValidator<AppUserDtos>
    {
        public AppUserValidator()
        {
                RuleFor(x=>x.Name).NotEmpty().WithMessage("Bu alan boş geçilemez");
                RuleFor(x=>x.SurName).NotEmpty().WithMessage("Bu alan boş geçilemez");
                RuleFor(x=>x.Email).NotEmpty().WithMessage("Bu alan boş geçilemez");
                RuleFor(x=>x.UserName).NotEmpty().WithMessage("Bu alan boş geçilemez");
                RuleFor(x=>x.Password).NotEmpty().WithMessage("Bu alan boş geçilemez");
                RuleFor(x=>x.Password).Equal(y=>y.ConfirmPassword).WithMessage("Girilen bilgiler eşleşmemektedir");
                RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Bu alan boş geçilemez");
                RuleFor(x=>x.UserName).MinimumLength(5).WithMessage("Bu alanda en az 5 karakter kullanılması zorunludur");
                RuleFor(x=>x.UserName).MaximumLength(20).WithMessage("Bu alanda en fazla 20 karakter kullanılması zorunludur");

        }
    }
}
