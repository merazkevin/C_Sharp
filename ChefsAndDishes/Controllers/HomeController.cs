using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ChefsAndDishes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context )
    {
        _logger = logger;
        _context = context;
    }

    //<=== Get Routes ===> 
    // [SessionCheck]
    [HttpGet("")]
    public IActionResult Index()
    {
        int? userId = HttpContext.Session.GetInt32("UserId");
        if(userId==null)
        {
            return View("Index");
        }
        else
        {

            return View("Success");
        }
    }
    public IActionResult Privacy()
    {
        return View();
    }



    [SessionCheck]
    [HttpGet("logout")]
    public IActionResult LogOut()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }



    // <=== Post Routes ===>
    [HttpPost("users/create")]
    public IActionResult CreateUser(User newUser)
    {
        if(ModelState.IsValid)
        {
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newUser.Password=Hasher.HashPassword(newUser, newUser.Password);
            _context.Add(newUser);
            _context.SaveChanges();
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            return RedirectToAction("AllChefs", "Chef");
        }
        else
        {
            return View("Index");
        }
    }

    [HttpPost("users/login")]
    public IActionResult LoginUsers(LogUser loginUser)
    {
        if(ModelState.IsValid)
        {
            User? userInDb = _context.Users.FirstOrDefault(u=>u.Email==loginUser.LEmail);
            if(userInDb==null)
            {
                ModelState.AddModelError("LEmail","Invalid Email/Password");
                return View("Index");
            }
            PasswordHasher<LogUser> hasher = new PasswordHasher<LogUser>();
            var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.LPassword);
            if(result==0)
            {
                ModelState.AddModelError("LEmail","Invalid Email/Password");
                return View("Index");
            }
            else
            {
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("AllChefs", "Chef");
            }
        }
        else{
            return View("Index");
        }
    }

    


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

public class SessionCheckAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        int? userId = context.HttpContext.Session.GetInt32("UserId");
        if(userId==null)
        {
            context.Result = new RedirectToActionResult("Index", "Home", null);
        }
    }
}