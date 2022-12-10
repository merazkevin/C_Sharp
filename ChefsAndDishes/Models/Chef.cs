using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ChefsAndDishes.Models;

public class Chef 
{
    [Key]
    public int ChefId {get;set;}
    [Required]
    public string FirstName {get;set;}
    [Required]
    public string LastName {get;set;}

    [Required]
    [DataType(DataType.Date)]
    [FutureDate]
    public DateTime DOB {get;set;}
    public List<Dish> Dishes {get;set;}=new List<Dish>();
    
    [NotMapped]
    public int Age
    {
        get
        {
            DateTime now= DateTime.Today;
            int age = now.Year -DOB.Year;
            if(DOB>now.AddYears(-age))age--;
                return age;
        }
    }
    public class FutureDateAttribute : ValidationAttribute
{

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        DateTime today = DateTime.Today;
        DateTime birth = (DateTime)value;
        var age = today.Year-birth.Year;
        if (birth.Date > today.AddYears(-age)) age--;
        if(age<18)
        {
            return new ValidationResult(ErrorMessage ="Must Be Over 18!");
        }

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

}