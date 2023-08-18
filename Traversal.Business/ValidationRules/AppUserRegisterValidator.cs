using FluentValidation;
using Traversal.DTOLayer.DTOs.AppUserDTOs;

namespace Traversal.Business.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez.");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız.");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter girişi yapınız.");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Girilen şifreler birbiriyle uyuşmuyor.");
        }
    }
}
