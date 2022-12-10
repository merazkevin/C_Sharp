using System.ComponentModel.DataAnnotations;
namespace ChefsAndDishes.Models;

public class Dish
{
    [Key]
    public int DishID{get;set;}
    [Required]
    public string DishName{get;set;}
    
    [Required]
    [Range(1,3000)]
    public int Calories{get;set;}
    [Required]
    public int ChefId{get;set;}
    public Chef? DishCreator {get;set;}
    
    public int Tastiness{get;set;}
}