using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

// <=== Get Routes ===>
    [HttpGet("")]
    public IActionResult Index()
    {
        StringClass message = new StringClass("Here is a message");
        ViewBag.MyNum = 9;
        return View(message);
    }
    [HttpGet("/numbers")]
    public IActionResult numbers()
    {
        NumArray ArrayNumbers = new NumArray();
        return View(ArrayNumbers);
    }

    [HttpGet("/user")]
    public IActionResult user()
    {
        UserModel userList = new UserModel(new string[]{"Brian"}, new string[]{"fan"});     

        return View(userList);
    }
    [HttpGet("/users")]
    public IActionResult users()
    {
        UserModel userList = new UserModel(new string[]{"Brian", "Steve"}, new string[]{"fan", "Young"});     

        return View(userList);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
