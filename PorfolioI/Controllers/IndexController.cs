// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace PorfolioI.Controllers;   
public class IndexController : Controller   // Remember inheritance?    
{      
    [HttpGet("")] // We will go over this in more detail on the next page    

    public IActionResult Index()        
    {            
        ViewBag.kevin = "kevin";
        ViewBag.Example = "Hellooo World!";
        return View ("Index");        
    } 
    
} 