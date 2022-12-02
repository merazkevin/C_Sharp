using Microsoft.AspNetCore.Mvc;
namespace PorfolioI.Controllers;

public class ProjectController :Controller
{
    [HttpGet("project")]
    public ViewResult DisplayProjects()
    {
        return View ("Project");
    }
}