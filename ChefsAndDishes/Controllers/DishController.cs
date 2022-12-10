using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace ChefsAndDishes.Controllers;

public class DishController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public DishController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    
    
    
    // <=== Get Routes ===>
    [SessionCheck]
    [HttpGet("dish/form")]
    public IActionResult DishForm()
    {
        ViewBag.AllChefs= _context.Chefs.ToList();
        return View("DishForm");
    }

    [SessionCheck]
    [HttpGet("dishes/display")]
    public IActionResult DisplayDishes()
    {
        List<Dish> AllUsersInDb = _context.Dishes.Include(c=>c.DishCreator).ToList();
        return View("Dishes", AllUsersInDb);
    }

    // <=== Post Routes ===>
    [SessionCheck]
    [HttpPost("dish/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {  
            
            _context.Dishes.Add(newDish);
            _context.SaveChanges();
            Console.WriteLine("<=== is Valid ===>");
            return RedirectToAction("DisplayDishes");
        }
        else
        {
            Console.WriteLine("<=== is Invalid ===>");
            return DishForm();
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}