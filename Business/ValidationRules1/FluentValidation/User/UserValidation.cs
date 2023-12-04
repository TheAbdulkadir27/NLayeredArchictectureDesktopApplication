namespace Business.ValidationRules1.FluentValidation.User
{
    using Entity.Concrete;
    using FluentValidation;
    using global::FluentValidation;

    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName Boş Olamaz");
            RuleFor(x => x.UserPass).NotEmpty().WithMessage("Password Alanı Boş Bırakılamaz");
            RuleFor(x => x.UserLevel).NotEmpty().WithMessage("Level Alanı Boş Bırakılamaz");
        }
    }
}
