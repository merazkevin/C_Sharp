using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionWorkShop.Models;


namespace SessionWorkShop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // <=== GetRoutes ===>
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet("SessionWorkshopLogin")]
    public IActionResult SessionWorkshopLogin()
    {
        
        if(HttpContext.Session.GetString("UserName")!=null)
        {
        return RedirectToAction("SessionDashBoard");
        }
        return View();
    }

    [HttpGet("SessionDashBoard")]
    public IActionResult SessionDashBoard()
    {
        
        if(HttpContext.Session.GetString("UserName")==null)
        {
        return Redirect("SessionWorkshopLogin");
        }
        return View();
    }

    [HttpGet("Logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return View("SessionWorkshopLogin");
    }

    // <=== PostRoutes ===>*
    [HttpPost("ProcessSessionDashBoard")]
    public IActionResult ProcessSessionDashBoard(string name)
    {
        HttpContext.Session.SetString("UserName", name);
        HttpContext.Session.SetInt32("UserStartingNum", 22);
        return View("SessionDashBoard");
    }

    //<=== +1 ===>
    [HttpPost("StartingNumPlusOne")]
    public IActionResult StartingNumPlusOne(int num)
    {
        int? SessionNum= HttpContext.Session.GetInt32("UserStartingNum");
        HttpContext.Session.SetInt32("UserStartingNum", (int)SessionNum +1);
        // HttpContext.Session.GetInt32("UserStartingNum");
        return RedirectToAction("SessionDashBoard");
    }

    //<=== -1 ===>
    [HttpPost("StartingNumMinusOne")]
    public IActionResult StartingNumMinusOne(int num)
    {
        
        HttpContext.Session.SetInt32("UserStartingNum", num -1);
        HttpContext.Session.GetInt32("UserStartingNum");
        return RedirectToAction("SessionDashBoard");
    }

    //<=== x2 ===>
    [HttpPost("StartingNumx2")]
    public IActionResult StartingNumx2(int num)
    {
        
        HttpContext.Session.SetInt32("UserStartingNum", num * 2);
        HttpContext.Session.GetInt32("UserStartingNum");
        return RedirectToAction("SessionDashBoard");
    }

    //<=== +Random ===>
    [HttpPost("PlusRandomNum")]
    public IActionResult PlusRandomNum(int num)
    {
        Random rand = new Random();
        int randomNum = rand.Next(1,11);
        Console.WriteLine(randomNum);
        HttpContext.Session.SetInt32("UserStartingNum", num + randomNum);
        HttpContext.Session.GetInt32("UserStartingNum");
        return RedirectToAction("SessionDashBoard");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
