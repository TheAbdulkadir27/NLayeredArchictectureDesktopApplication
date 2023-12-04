using FluentValidation;
namespace Business.ValidationRules1.FluentValidation.Sofor
{
    using Entity.Concrete;
    public class SoforValidation : AbstractValidator<Sofor>
    {
        public SoforValidation()
        {
            RuleFor(x => x.pid).NotEmpty().WithMessage("Proje Alanı Boş Bırakılamaz");
            RuleFor(x => x.sevkno).NotEmpty().WithMessage("SevkNo Alanı Boş Bırakılamaz");
            RuleFor(x => x.sevksorumlu).NotEmpty().WithMessage("Sevk Sorumlusu Boş Bırakılamaz");
            RuleFor(x => x.imalatsorumlu).NotEmpty().WithMessage("İmalat Sorumlusu Boş Bırakılamaz");
            RuleFor(x => x.kalitesorumlu).NotEmpty().WithMessage("Kalite Sorumlusu Boş Bırakılamaz");
            RuleFor(x => x.soforadi).NotEmpty().WithMessage("Sofor Adı Boş Bırakılamaz");
            RuleFor(x => x.sofortel).NotEmpty().WithMessage("Sofor Teli Boş Bırakılamaz");
            RuleFor(x=>x.aracplaka).NotEmpty().WithMessage("Araç Plakası Boş Geçilemez");
            RuleFor(x => x.dorseplaka).NotEmpty().WithMessage("Dorse Plaka Boş Geçilemez");
            RuleFor(x => x.kantarkilo).NotEmpty().WithMessage("Kantar Kilo Boş Geçilemez");
            RuleFor(x => x.konteynerno).NotEmpty().WithMessage("Konteyner No Boş Geçilemez");
        }
    }
}
