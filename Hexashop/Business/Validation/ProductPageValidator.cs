using EPiServer.Validation;
using Hexashop.Models.Pages;

namespace Hexashop.Business.Validation
{
    public class ProductPageValidator : IValidate<ProductPage>
    {
        public IEnumerable<ValidationError> Validate(ProductPage instance)
        {
            if (instance.Price < 0)
            {
                yield return new ValidationError()
                {
                    ErrorMessage = "Invalid price",
                    PropertyName = "Price",
                    Severity = ValidationErrorSeverity.Error
                };
            }

            if (instance.ProductName.Length < 3)
            {
                yield return new ValidationError()
                {
                    ErrorMessage = "Enter longer product name",
                    PropertyName = nameof(ProductPage.ProductName),
                    Severity = ValidationErrorSeverity.Warning
                };
            }
        }
    }
}
