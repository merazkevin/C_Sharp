// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace YourNamespace.Controllers;   

public class HelloController : Controller   // Remember inheritance? 
{
    //Routing!!
    // this tells your contyroller we have a web page we want to see (or GET)
    [HttpGet]
    //what is thw URL?
    //rhis goes to localhost: 5xxx/
    [Route("")]
    public string Index(){
        return("hello from our Index page");
    }

    // This will go to "localhost:5XXX/user/more"
    [HttpGet("user/more")]
    public string User()
    {
        return "Hello user";
    }

    [HttpGet("greet/{name}")]
    public string Greet(string name)
    {
        return $"Hello {name}!";
    }
    
    [HttpGet("greet/{name}/{time}")]
    public string GreetTime(string name, string time)
    {
        return $"Good {time}, {name}!";
    }

}