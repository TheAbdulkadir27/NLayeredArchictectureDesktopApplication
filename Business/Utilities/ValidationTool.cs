using FluentValidation;

namespace Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object Entity)
        {
            var context = new ValidationContext<object>(Entity);
            var result = validator.Validate(context);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
