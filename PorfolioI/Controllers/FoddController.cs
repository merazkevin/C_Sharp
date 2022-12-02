using Microsoft.AspNetCore.Mvc;
namespace PorfolioI.Controllers;

public class FoodController :Controller
{
    [HttpGet("food")]

    public ViewResult DisplayFood()
    {
        return View("Food");
    }
}