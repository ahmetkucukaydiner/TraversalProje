using FluentValidation;
using Traversal.Entities.Concrete;

namespace Traversal.Business.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber adını giriniz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklamasını giriniz.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Lütfen rehber fotoğrafını yükleyiniz.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir isim giriniz.");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Lütfen 5 karakterden daha uzun bir isim giriniz.");
        }
    }
}
