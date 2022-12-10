using System.ComponentModel.DataAnnotations;
namespace ChefsAndDishes.Models; //!Change If Needed

public class LogUser
{
    [Required]
    [EmailAddress]
    public string LEmail{get;set;}

    [Required]
    [DataType(DataType.Password)]
    public string LPassword{get;set;}

}
