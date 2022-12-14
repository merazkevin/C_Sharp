namespace ProductsAndCategories.Models;

public class CategoryViews
{
    public Category? Category { get; set; }
    public Association? Association { get; set; }
    public List<Association> Associations { get; set; } = new List<Association>();


    public List<Category> Categories { get; set; } = new List<Category>();
}