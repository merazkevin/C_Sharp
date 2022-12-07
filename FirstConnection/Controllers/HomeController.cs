using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstConnection.Models;
namespace FirstConnection.Controllers;


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
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet("Create/Pet")]
    public IActionResult CreatePet()
    {
        return View();
    }

    [HttpGet("Show/Pets")]
    public IActionResult ShowPets()
    {
        List<Pet> AllPets = _context.Pets.ToList();
        return View("ShowPets", AllPets);
    }
// <=== Post Routes ===>
    [HttpPost("Process/Create/Pet")]
    public IActionResult ProcessCreatePet(Pet newPet)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newPet);
            _context.SaveChanges();
            return RedirectToAction("ShowPets");
        }
        // else
        // {
        return View("Privacy");
        // }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
