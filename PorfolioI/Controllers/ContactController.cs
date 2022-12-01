using Microsoft.AspNetCore.Mvc;
namespace PorfolioI.Controllers;

public class Contact : Controller
{
    [HttpGet("Contacts")]

    public string DisplayContact()
    {
        return "This are all my Contacts";
    }
}