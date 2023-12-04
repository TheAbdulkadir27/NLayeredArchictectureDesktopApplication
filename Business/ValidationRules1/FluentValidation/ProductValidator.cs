using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules1.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün İsmi Boş Geçilemez");
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("UnitPrice Boş olamaz");
            RuleFor(x => x.QuantityPerUnit).NotEmpty().WithMessage("QuantityPerUnit Boş Geçilemez");
            RuleFor(x => x.UnitİnStock).NotEmpty().WithMessage("UnitİnStock Boş Geçilemez");
            RuleFor(x => x.UnitPrice).GreaterThan(0).WithMessage("Unit Price 0 Dan Büyük Olmalıdır");
            RuleFor(x => x.UnitPrice).GreaterThan(10).When(x => x.CategoryID == 2);
        }
    }
}
