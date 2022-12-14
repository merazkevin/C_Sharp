namespace ProductsAndCategories.Models;

public class ProductViews
{
    public Product? Product {get;set;}
    public Category? Category{get;set;}
    public Association? Association{get;set;}
    public List<Product> Products {get;set;}= new List<Product>();
    public List<Category> Categories {get;set;}= new List<Category>();
    public List<Association> Associations {get;set;}= new List<Association>();
}