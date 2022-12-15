using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlanner.Models;

public class Wedding
{
    [Key]
    public int WeddingId { get; set; }
    [Required]
    public String WedderOne { get; set; }
    [Required]
    public String WedderTwo { get; set; }
    [Required]
    [DataType(DataType.Date)]
    [FutureDate]
    public DateTime? Date { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    [Required]
    public string? Address { get; set; }
    public List<Rsvp> Rsvps { get; set; } = new List<Rsvp>();
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

public class FutureDateAttribute : ValidationAttribute
{

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        
        if ((DateTime)value < DateTime.Now)
        {
            return new ValidationResult(ErrorMessage ="Please select a Future date");
        }


        else
        {
            return ValidationResult.Success;
        }
    }
}

}
