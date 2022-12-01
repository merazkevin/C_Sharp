// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace PorfolioI.Controllers;   
public class HelloController : Controller   // Remember inheritance?    
{      
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public string Index()        
    {            
        return "This is the Index";        
    } 
    
    // [HttpGet] // We will go over this in more detail on the next page    
    // [Route("Something")] // We will go over this in more detail on the next page
    // public string SomeThing()        
    // {            
    //     return "Hello World from <=== Soemthing Route ===> HelloController!";        
    // }    
} 