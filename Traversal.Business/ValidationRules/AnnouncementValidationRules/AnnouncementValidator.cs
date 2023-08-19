using FluentValidation;
using Traversal.DTOLayer.DTOs.AnnouncementDTOs;

namespace Traversal.Business.ValidationRules.AnnouncementValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDto>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen başlığı boş geçmeyin");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen duyuru içeriğini boş geçmeyin");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri giriniz");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Lütfen en az 20 karakter veri giriniz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter veri giriniz");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen en fazla 500 karakter veri giriniz");
        }
    }
}
