using FluentValidation;

namespace Business.ValidationRules1.FluentValidation.Sevkiyat
{
    using Entity.Concrete;
    public class SevkiyatValidation : AbstractValidator<Sevkiyat>
    {
        public SevkiyatValidation()
        {
            RuleFor(x => x.sevkno).NotNull().WithMessage("Sevk No Boş Bırakılamaz");
            RuleFor(x => x.sevktarihi).NotEmpty().WithMessage("Sevk Tarihi Boş Geçilemez");
            RuleFor(x => x.pozno).NotEmpty().WithMessage("PozNo Boş Bırakılamaz");
            RuleFor(x => x.sevkadet).NotEmpty().WithMessage("Sevk Adet Boş Geçilemez");
            RuleFor(X => X.sevkkilo).NotEmpty().WithMessage("SevkKilo Boş Geçilemez");
            RuleFor(x => x.sevktopkilo).NotEmpty().WithMessage("SevkTopKilo Boş Geçilemez");
            RuleFor(x => x.paketno).NotEmpty().WithMessage("Paket No Boş Bırakılamaz");
        }
    }
}
