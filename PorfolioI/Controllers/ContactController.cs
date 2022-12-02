using Microsoft.AspNetCore.Mvc;
namespace PorfolioI.Controllers;

public class Contact : Controller
{
    [HttpGet("contact")]

    public ViewResult DisplayContact()
    {
        return View("Contact");
    }
}