using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers;

public class RsvpController : Controller
{
    private MyContext _context;

    public RsvpController(MyContext context)
    {

        _context = context;
    }
    //TODO <=== Get Routes===>

    //TODO <=== Post Routes ===>
    [HttpPost("rsvp/{UserId}/{WeddingId}/create")]
    public IActionResult CreateRsvp(int weddingId, int userId, Rsvp newRsvp)
    {
        BagUserName();
        _context.Rsvps.Add(newRsvp);
        _context.SaveChanges();
        return RedirectToAction("Dashboard", "User");
    }

    [HttpPost("rsvp/{UserId}/{WeddingId}/destroy")]
    public IActionResult DestroyRsvp(int weddingId, int userId, Rsvp newRsvp)
    {
        Rsvp rsvpToDestroy = _context.Rsvps.SingleOrDefault(e=>e.UserId==userId&& e.WeddingId==weddingId);
        BagUserName();
        _context.Rsvps.Remove(rsvpToDestroy);
        _context.SaveChanges();
        return RedirectToAction("Dashboard", "User");
    }


    public void BagUserName()
    {
        int? LogUser = HttpContext.Session.GetInt32("UserId");
        User? logUser = _context.Users.FirstOrDefault(e => e.UserId == LogUser);
        ViewBag.Name = logUser.FirstName;
    }
}