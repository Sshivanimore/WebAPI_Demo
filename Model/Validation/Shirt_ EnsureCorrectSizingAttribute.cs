using System.ComponentModel.DataAnnotations;

namespace WebAPI_Demo.Model.Validation
{
    public class Shirt__EnsureCorrectSizingAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt = validationContext.ObjectInstance as ShirtsModel;
            if (shirt != null && !string.IsNullOrWhiteSpace(shirt.gender))
            {
                if(shirt.gender.Equals("men",StringComparison.OrdinalIgnoreCase) && shirt.size < 8)
                {
                    return new ValidationResult("For mens shirts, the size has to be greater or equal to 8.");
                }
                else if(shirt.gender.Equals("women",StringComparison.OrdinalIgnoreCase) && shirt.size < 6)
                {
                    return new ValidationResult("For women shirts, the size has to be greater or equal to 6.");
                }

            }

            return ValidationResult.Success;

        }

    }
}
