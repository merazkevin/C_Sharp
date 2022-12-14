using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;

namespace DojoSurveyWithModel.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    // <=== Constructor ===>
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // <=== Get Routes ===>
    //  <== index ==> 
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    //  <== privacy ==>
    [HttpGet("Privacy")]
    public IActionResult Privacy()
    {
        return View();
    }
    //  <== DojoForm ==>
    [HttpGet("DojoForm")]
    public IActionResult DojoForm()
    {
        return View();
    }

    //  <== OneDojoForm ==>
    [HttpGet("ProcessDojoForm")]
    public IActionResult ProcessDojoForm()
    {
        return View();
    }

    //<=== Post Routes ===>
    //  <== DojoForm ==>
    [HttpPost("ProcessDojoForm")]
    public IActionResult ProcessDojoForm(DojoFormClass oneForm)
    {
        if(ModelState.IsValid)
        {
            Console.WriteLine("Validation Warning");
            return View("ProcessDojoForm", oneForm);
        }

        else
        {
            return View("DojoForm");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
