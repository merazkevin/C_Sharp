using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace ChefsAndDishes.Controllers;

public class ChefController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public ChefController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }
    // <=== get Routes ===>

    [SessionCheck]
    [HttpGet("chef")]
    public IActionResult Chef()
    {
        return View("ChefForm");
    }
    // <=== post Routes ===>
    [HttpPost("chefs/create")]
    public IActionResult CreateChefs(Chef newChef)
    {
        
        if (ModelState.IsValid)
        {
            _context.Add(newChef);
            _context.SaveChanges();
            Console.WriteLine("this is valid");
            return RedirectToAction("AllChefs");
        }
        else
        {
            Console.WriteLine("Is invalid");
            return View("ChefForm");
        }
    }

[SessionCheck]
[HttpGet("chefs")]
public IActionResult AllChefs()
{
    //getting User id from session
    int? LogUserId =HttpContext.Session.GetInt32("UserId");
    //getting user's firstname and putting it  in viewbag.
    User? UserInDb = _context.Users.FirstOrDefault(u=>u.UserId==LogUserId);
    ViewBag.LogUserName = UserInDb.FirstName;
    //getting all chefs from Db make sure to check the EntityFrameworkCore
    List<Chef> AllChefs = _context.Chefs.Include(c=>c.Dishes).ToList();
    return View("Success", AllChefs);
}





    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

