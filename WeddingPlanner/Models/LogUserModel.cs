using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models; 

public class LogUser
{
    [Required]
    [EmailAddress]
    public string LEmail{get;set;}

    [Required]
    [DataType(DataType.Password)]
    public string LPassword{get;set;}

}
