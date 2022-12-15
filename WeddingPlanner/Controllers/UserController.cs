using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers;

public class UserController : Controller
{
    private MyContext _context;

    public UserController(MyContext context)
    {

        _context = context;
    }
    //TODO <=== Get Routes===>
    [HttpGet("")]
    public IActionResult Index()
    {
        int? logUser = HttpContext.Session.GetInt32("UserId");
        if (logUser != null)
        {
            return RedirectToAction("Dashboard");
        }
        else
        {
            return View("Index");
        }
    }

    [SessionCheck]
    [HttpGet("dashboard")]
    public IActionResult Dashboard()
    {
        
        ViewModel allWeds = new ViewModel();
        List<Wedding> AllWeds =_context.Weddings
                                    .Include(e =>e.User)
                                    .Include(e =>e.Rsvps)
                                    .ThenInclude(e=>e.User)
                                    .ToList();
            allWeds.Weddings=AllWeds;
        BagUserName();
        return View("Dashboard", allWeds);
    }

    [SessionCheck]
    [HttpGet("logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }



    //TODO <=== Post Routes ===>
    [HttpPost("users/create")]
    public IActionResult CreateUsers(User newUser)
    {
        if (ModelState.IsValid)
        {
            if (newUser == null)
            {
                return Index();
            }
            else
            {
                Console.WriteLine("<=== Is Valid ===>");
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Users.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                return RedirectToAction("Dashboard");
            }
        }
        else
        {
            Console.WriteLine("*** Invalid ***");
            return Index();
        }
    }

    [HttpPost("users/login")]
    public IActionResult LoginUsers(LogUser loginUser)
    {
        User? userInDb = _context.Users.FirstOrDefault(u => u.Email == loginUser.LEmail);
        if (userInDb == null)
        {
            ModelState.AddModelError("LEmail", "Invalid Email/Password");
            return View("Index");
        }
        PasswordHasher<LogUser> hasher = new PasswordHasher<LogUser>();
        var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.LPassword);
        if (result == 0)
        {
            ModelState.AddModelError("LEmail", "Invalid Email/Password");
            return View("Index");
        }
        else
        {
            HttpContext.Session.SetInt32("UserId", userInDb.UserId);
            return RedirectToAction("Dashboard");
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public void BagUserName()
    {
        int? LogUser = HttpContext.Session.GetInt32("UserId");
        User? logUser = _context.Users.FirstOrDefault(e => e.UserId == LogUser);
        ViewBag.Name = logUser.FirstName;
    }
}

public class SessionCheckAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        int? userId = context.HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            context.Result = new RedirectToActionResult("Index", "User", null);
        }
    }
}