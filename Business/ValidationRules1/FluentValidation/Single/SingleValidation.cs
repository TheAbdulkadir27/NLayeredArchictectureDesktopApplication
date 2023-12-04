using FluentValidation;

namespace Business.ValidationRules1.FluentValidation.Single
{
    using Entity.Concrete;
    public class SingleValidation : AbstractValidator<Single>
    {
        public SingleValidation()
        {
            RuleFor(x => x.pid).NotEmpty().WithErrorCode("Proje Boş Geçilemez");
            RuleFor(x => x.assemid).NotNull().WithErrorCode("Assembly Boş Geçilemez");
            RuleFor(x => x.sisim).NotNull().WithMessage("Single İsim Boş Geçilemez");
            RuleFor(x => x.sprofile).NotNull().WithMessage("Single Profili Boş Geçilemez");
            RuleFor(x => x.sadet).NotNull().WithMessage("Single Adeti Boş Geçilemez");
            RuleFor(x => x.assemxsing).NotNull().WithMessage("Assembly Single Boş Geçilemez");
            RuleFor(x => x.suzunluk).NotNull().WithMessage("Uzunluk Boş Geçilemez");
            RuleFor(x => x.skilo).NotNull().WithMessage("Skilo Boş Geçilemez");
        }
    }
}
