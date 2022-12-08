using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginAndReg.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LoginAndReg.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }
// <=== Get Routes ===>

    [HttpGet("")]  
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("user")]  
    public IActionResult LoginAndReg()
    {
        return View("LoginReg");
    }

    [SessionCheck]
    [HttpGet(("success"))]  
    public IActionResult Success()
    {
        return View("Success");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    // <=== PostRoutes ===>

    [HttpPost("users/create")]
    public IActionResult CreateUser(User newUser)
    {
        if(ModelState.IsValid)
        {
            // Hash pass
            PasswordHasher<User> Hasher =new PasswordHasher<User>();
            newUser.Password=Hasher.HashPassword(newUser, newUser.Password);
            _context.Add(newUser);
            _context.SaveChanges();
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            return RedirectToAction("Success");
        }
        else
        {
            return View("LoginReg");
        }
    }

    [HttpPost("users/login")]
    public IActionResult LoginUser( LogUser loginUser)
    {
        if(ModelState.IsValid)
        {
            User? userInDb = _context.Users.FirstOrDefault(u=>u.Email==loginUser.LEmail);
            if(userInDb==null)
            {
                ModelState.AddModelError("LEmail","Invalid Email/Password");
                return View("LoginReg");
            }
            PasswordHasher<LogUser> hasher = new PasswordHasher<LogUser>();
            var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.LPassword);
            if(result==0)
            {
                ModelState.AddModelError("LEmail","Invalid Email/Password");
                return View("LoginReg");
            }
            else
            {
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Success");
            }
        }
        else{
            return View("LoginReg");
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
            context.Result = new RedirectToActionResult("LoginAndReg", "Home", null);
        }
    }
}