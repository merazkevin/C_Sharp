using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers;

public class WeddingController : Controller
{
    private MyContext _context;

    public WeddingController(MyContext context)
    {

        _context = context;
    }
    //TODO <=== Get Routes===>
    [HttpGet("wedding/new")]
    public IActionResult NewWedding()
    {
        BagUserName();
        return View("WeddingForm");
    }
    [HttpGet("wedding/{weddingId}")]
    public IActionResult OneWedding(int weddingId)
    {
        BagUserName();
        ViewModel currentViewModel = new ViewModel();
        Wedding currentWedding = _context.Weddings
                                .Include(e => e.Rsvps)
                                .ThenInclude(e => e.User)
                                .ToList()
                                .FirstOrDefault(e => e.WeddingId == weddingId);
        currentViewModel.Wedding=currentWedding;
        return View("OneWedding", currentViewModel);
    }
    //TODO <=== Post Routes ===>
    [HttpPost("wedding/create")]
    public IActionResult CreateWedding(Wedding newWedding)
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine("<=== Is Valid ===>");
            _context.Weddings.Add(newWedding);
            _context.SaveChanges();
            int weddingId = newWedding.WeddingId;
            return RedirectToAction("OneWedding", new { weddingId = weddingId });
        }
        else
        {
            Console.WriteLine("*** Not VALID ***");
            return NewWedding();
        }
    }

    [HttpPost("wedding/{weddingId}/destroy")]
    public IActionResult DestroyWedding(int weddingId)
    {
        Wedding weddingToDestroy = _context.Weddings.SingleOrDefault(e => e.WeddingId ==weddingId);
        _context.Weddings.Remove(weddingToDestroy);
        _context.SaveChanges();
        BagUserName();
        return RedirectToAction("Dashboard", "User");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public void BagUserName()
    {
        int? LogUser = HttpContext.Session.GetInt32("UserId");
        User? logUser = _context.Users.FirstOrDefault(e => e.UserId == LogUser);
        ViewBag.Name = logUser.FirstName;
        ViewBag.UserId = logUser.UserId;
    }
}