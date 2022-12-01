    using Microsoft.AspNetCore.Mvc;
    namespace PorfolioI.Controllers;  
    
    public class SomeThing : Controller
    {
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("Something")] // We will go over this in more detail on the next page
    public string SaySome()        
    {            
        return "Hello World from <=== Soemthing Route ===> HelloController!";        
    } 
    }