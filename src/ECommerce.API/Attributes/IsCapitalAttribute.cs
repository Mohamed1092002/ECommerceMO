using ECommerce.API.Dtos.CategoryDto;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.API.Attributes
{
    public class IsCapitalAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var result = (ICommandDto)validationContext.ObjectInstance;

            var firstChar = result.Name[0];

            if (!char.IsUpper(firstChar))
            {
                return new ValidationResult("Name Must be Capitalization");
            }

            return ValidationResult.Success;
        }
    }
}
