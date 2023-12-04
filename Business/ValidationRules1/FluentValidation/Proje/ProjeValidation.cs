using FluentValidation;

namespace Business.ValidationRules1.FluentValidation.Proje
{
    using Entity.Concrete;
    public class ProjeValidation : AbstractValidator<Proje>
    {
        public ProjeValidation()
        {
            RuleFor(x => x.pkod).NotEmpty().WithMessage("PKod Alanını Lütfen Boş Geçmeyiniz");
            RuleFor(x => x.pisim).NotEmpty().WithMessage("Pİsim Alanını Lütfen Boş Geçmeyiniz");
        }
    }
}
