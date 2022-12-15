using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlanner.Models;

public class User
{
    [Key]
    public int UserId{get;set;}

    [Required]
    [MinLength(2,ErrorMessage ="Must be at least 2 charracters")]
    public string FirstName{get;set;}

    [Required]
    [MinLength(2,ErrorMessage ="Must be at least 2 charracters")]
    public string LastName{get;set;}

    [Required]
    [EmailAddress]
    [UniqueEmail]
    public string Email{get;set;}

    [Required]
    [MinLength(8,ErrorMessage ="Must be at least 8 charracters")]
    [DataType(DataType.Password)]
    public string Password{get;set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


    public List<Wedding> Weddings{get;set;}= new List<Wedding>();
    public List<Rsvp> Rsvps{get;set;}= new List<Rsvp>();
    [NotMapped]
    [DataType(DataType.Password)]
    [Compare("Password")]
    public string PasswordConfirm{get;set;}
}

public class UniqueEmailAttribute: ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if(value==null)
        {
            return new ValidationResult("Email is Required");
        }
        
        MyContext _context = (MyContext)validationContext.GetService(typeof(MyContext));
        if(_context.Users.Any(e=>e.Email==value.ToString()))
        {
            return new ValidationResult("Email must be unique.");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}