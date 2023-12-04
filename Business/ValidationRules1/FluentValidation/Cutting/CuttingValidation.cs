using FluentValidation;
namespace Business.ValidationRules1.FluentValidation.Cutting
{
    using Entity.Concrete;
    public class CuttingValidation : AbstractValidator<Cutting>
    {
        public CuttingValidation()
        {
            RuleFor(x => x.cutdate).NotEmpty().WithMessage("Lütfen bir tarih giriniz");
            RuleFor(x => x.pid).NotEmpty().WithMessage("Proje Boş Geçilemez");
            RuleFor(x => x.profile).NotEmpty().WithMessage("Profile Boş Geçilemez");
            RuleFor(x => x.comment).NotEmpty().WithMessage("Yorumlar Kısmı Boş Bırakılamaz");
            RuleFor(x => x.assemkod).NotEmpty().WithMessage("Assemkod Boş Bırakılamaz");
            RuleFor(x => x.single).NotEmpty().WithMessage("Single Alanı Boş Bırakılamaz");
            RuleFor(x => x.cutqty).NotEmpty().WithMessage("CutMiktar Alanı Boş Bırakılamaz");
            RuleFor(x => x.cutno).NotEmpty().WithMessage("CutNo Boş Geçilemez");
            RuleFor(x => x.skilo).NotEmpty().WithMessage("Skilo Alanı Boş Geçilemez");
        }
    }
}
