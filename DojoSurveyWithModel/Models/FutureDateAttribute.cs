using System.ComponentModel.DataAnnotations;


public class FutureDateAttribute : ValidationAttribute
{

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if(value==null)
        {
            return new ValidationResult(ErrorMessage ="Please select a date");
        }
        if ((DateTime)value > DateTime.Now)
        {
            return new ValidationResult(ErrorMessage ="Please select a previous date");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}
