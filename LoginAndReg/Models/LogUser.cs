using System.ComponentModel.DataAnnotations;
namespace LoginAndReg.Models; 

public class LogUser
{
    [Required]
    [EmailAddress]
    public string LEmail{get;set;}

    [Required]
    [DataType(DataType.Password)]
    public string LPassword{get;set;}

}
