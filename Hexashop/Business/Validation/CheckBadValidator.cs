using System.ComponentModel.DataAnnotations;

namespace Hexashop.Business.Validation
{
    public class CheckBadValidator : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return !value?.ToString()?.Contains("bad") ?? true;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"Invalid {name}";
        }
    }
}
