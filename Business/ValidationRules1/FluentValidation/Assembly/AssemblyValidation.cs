using FluentValidation;
namespace Business.ValidationRules1.Assembly
{
    using Entity.Concrete;
    public class AssemblyValidation : AbstractValidator<Assembly>
    {
        public AssemblyValidation()
        {
            RuleFor(x => x.assemkod).MaximumLength(15).WithMessage("AssemblyKod Maximum 15 Karakter Olabilir");
            RuleFor(x => x.sevkadet).NotEmpty().WithMessage("Adet Miktarı Boş Geçilemez");
            RuleFor(x => x.assemkilo).NotEmpty().WithMessage("Kilo Miktarı Boş Geçilemez");
            RuleFor(x => x.pid).NotEmpty().WithMessage("Assembly Projesi Boş Geçilemez");
            RuleFor(x => x.cutno).NotEmpty().WithMessage("Lütfen Bir CutNo Giriniz");
            RuleFor(x => x.cutdate).NotEmpty().WithMessage("Lütfen CutDate Alanını Boş Bırakmayınız");
        }
    }
}
