using System.ComponentModel.DataAnnotations;
namespace ProductsAndCategories.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    [Required]
    public string Name { get; set; }
    public List<Association> Associations{get;set;}= new List<Association>();
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    [Required]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}