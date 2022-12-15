using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlanner.Models;

public class ViewModel 
{
    public Wedding? Wedding{get;set;}
    public User? User{get;set;}
    public Rsvp? Rsvp{get;set;}
    public List<Wedding> Weddings{get;set;}= new List<Wedding>();
    public List<User> Users{get;set;}= new List<User>();
    public List<Rsvp> Rsvps{get;set;}= new List<Rsvp>();
}