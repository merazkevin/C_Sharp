using System.ComponentModel.DataAnnotations;
namespace ProductsAndCategories.Models;

public class Association
{
    [Key]
    [Required]
    public int AssociationId { get; set; }
    //tracks the Ids of ours models
    [Required]
    public int ProductId {get; set;}
    [Required]
    public int CategoryId { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    [Required]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    //Navigations Properties
    public Product? Product { get; set; }
    public Category? Category { get; set; }

}