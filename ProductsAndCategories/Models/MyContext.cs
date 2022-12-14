using Microsoft.EntityFrameworkCore;
namespace ProductsAndCategories.Models;

public class MyContext : DbContext 
    {   
        // This line will always be here. It is what constructs our context upon initialization  
        public MyContext(DbContextOptions options) : base(options) { }    
        // We need to create a new DbSet<Model> FOR EVERY MODEL in our project that is making a table
        // The name of our table in our database will be based on the name we provide here
        // This is where we provide a plural version of our model to fit table naming standards    
        public DbSet<Product> Products { get; set; } 
        public DbSet<Association> Associations { get; set; } 
        public DbSet<Category> Categories { get; set; } 
    } 