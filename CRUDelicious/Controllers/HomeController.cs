using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger,MyContext context)
    {
        _logger = logger;
        _context = context; 
    }

    // <=== Get Routes ===>
    [HttpGet("/")]
    public IActionResult Index()
    {
        return View();
    }
    // AllDishes
    [HttpGetAttribute("dish/all")]
    public IActionResult All()
    {
        List<Dish> AllDishes = _context.Dish.ToList();
        return View("CRUDelicious",AllDishes);
    }

    //Add
    [HttpGet("dish/Add")]
    public IActionResult Add()
    {
        return View("AddDish");
    }

    // displayOne
    [HttpGet("dish/{dishId}/display")]
    public IActionResult Display(int dishId)
    {
        Console.WriteLine(dishId);
        Dish? DishToShow =_context.Dish.SingleOrDefault(a=>a.DishId==dishId);
        return View("OneDish", DishToShow);
    }

    // displayForm
    [HttpGet("dish/{dishId}/update")]
    public IActionResult DisplayForm(int dishId)
    {
        Console.WriteLine(dishId);
        Dish? DishToShow =_context.Dish.SingleOrDefault(a=>a.DishId==dishId);
        return View("DishUpdate",DishToShow);
    }

    // <=== Post Routes ===>
    //Destroy
    [HttpPost("dish/{dishId}/destroy")]
    public IActionResult Destroy(int dishId)
    {
        if(ModelState.IsValid)
        {
            Dish? DishToDestroy =_context.Dish.SingleOrDefault(a=>a.DishId==dishId);
            _context.Dish.Remove(DishToDestroy);
            _context.SaveChanges();
            return RedirectToAction("All");
        }
        else
        {
            return RedirectToAction("Add");
        }
    }

    // dish/process
    public IActionResult dishProcess(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("All");
        }
        else
        {
            return RedirectToAction("Add");
        }
    }

    // ProcessDishUpdate
    [HttpPost("dish/{dishId}/process")]
    public IActionResult ProcessDishUpdate(int dishId, Dish newDish)
    {
        Dish? UpdatedDish = _context.Dish.FirstOrDefault(a=>a.DishId == dishId);
        if(UpdatedDish==null)
        {
            return RedirectToAction("DisplayForm", newDish); 
        }
        if(ModelState.IsValid)
        {
            Console.WriteLine(newDish.Name);
            UpdatedDish.Name = newDish.Name;
            UpdatedDish.Chef = newDish.Chef;
            UpdatedDish.Tastiness = newDish.Tastiness;
            UpdatedDish.Calories = newDish.Calories;
            UpdatedDish.UpdatedAt = DateTime.Now;
            _context.Dish.Update(UpdatedDish);
            _context.SaveChanges();
            return RedirectToAction("All");
        }
        else
        {
            return RedirectToAction("DisplayForm", UpdatedDish);
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
