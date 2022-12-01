using Microsoft.AspNetCore.Mvc;
namespace PorfolioI.Controllers;

public class ProjectController :Controller
{
    [HttpGet("projects")]
    public string DisplayProjects()
    {
        return "These are my Projects!";
    }
}