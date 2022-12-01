// Notice the use of the "Models" tag the same way we put "Controllers" in our Controller file
namespace YourNamespace.Models;
public class Friend    
{    
    // We must put {get;set;} after all our properties
    // This will give ASP.NET Core the permissions it needs to modify the values    
    public string FirstName {get;set;}        
    public string LastName {get;set;}        
    public string Location {get;set;}
    public int Age {get;set;}    
}