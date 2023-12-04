using FluentValidation;
namespace Business.ValidationRules1.FluentValidation.Plates
{
    using Entity.Concrete;
    public class PlatesValidation : AbstractValidator<Plates>
    {
        public PlatesValidation()
        {
            RuleFor(x => x.plateNo).NotEmpty().WithMessage("Lütfen PlateNo BOŞ Bırakmayınız");
        }
    }
}
