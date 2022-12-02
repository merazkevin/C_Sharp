using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;

public class IndexController : Controller
{
    // <=== static Fields ===>
    static string Name;
    static string DojoLocation;
    static string FavoriteLanguage;
    static string Comment;
    string Error = "required field";

    // <=== Get Routes===>
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet("forminfo")]
    public ViewResult FormInfo()
    {
        ViewBag.Name=Name;
        ViewBag.DojoLocation=DojoLocation;
        ViewBag.FavoriteLanguage=FavoriteLanguage;
        ViewBag.Comment = Comment;
        if(ViewBag.Comment==null)
        {
            ViewBag.Comment="No Comment";
        } 
        return View("FormInfo");
    }

    

    // <=== Post/Redirect Routes===>
    [HttpPost("process/forminfo")]
    public IActionResult  form(
        string name,
        string dojoLocation,
        string favoriteLanguage,
        string comment
    )
    {   
        Name = name;
        DojoLocation = dojoLocation;
        FavoriteLanguage = favoriteLanguage;
        Comment = comment;
        Console.WriteLine(dojoLocation);
        return Redirect("/forminfo");
    }
}