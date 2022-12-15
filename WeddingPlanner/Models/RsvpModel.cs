using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlanner.Models;

public class Rsvp
{
    [Key]
    public int RsvpId{get;set;}
    [Required]
    public int UserId{get;set;}
    [Required]
    public int WeddingId{get;set;}
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    [Required]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    //Navigation Properties
    public User? User{get;set;}
    public Wedding? Wedding{get;set;}
}