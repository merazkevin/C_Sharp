using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductsAndCategories.Models;
using Microsoft.EntityFrameworkCore;
namespace ProductsAndCategories.Controllers;

public class ProductController : Controller
{
    private MyContext _context;


    public ProductController(MyContext context)
    {
        _context = context;
    }
    //TODO <=== Get Routes ===>
    [HttpGet("")]
    public IActionResult Product()
    {
        List<Product> AllProducts = _context.Products
        .Include(e => e.Associations)
        .ThenInclude(e => e.Category)
        .ToList();
        ProductViews productViews = new ProductViews();
        productViews.Products = AllProducts;
        return View("Product", productViews);
    }

    [HttpGet("products/{productId}")]
    public IActionResult ShowProduct(int productId)
    {
        Console.WriteLine("<=== this is the Top PRoduct Name ===>");
        ViewBag.Categories = _context.Categories.ToList();
        ProductViews oneProductWithCategory = new ProductViews();
        Product? oneProduct = _context.Products
            .Include(e => e.Associations)
            .ThenInclude(e => e.Category)
            .FirstOrDefault(e => e.ProductId == productId);
        oneProductWithCategory.Product = oneProduct;
        Console.WriteLine("<=== this is the BottomPRoduct Name ===>");
        return View("ShowProduct", oneProductWithCategory);
    }

    //TODO <=== Post Routes ===>
    [HttpPost("product/create")]
    public IActionResult CreateProduct(Product newProduct)
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine(newProduct.Name);
            Console.WriteLine("Is Valid");
            _context.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("Product");
        }
        else
        {
            Console.WriteLine("<=== Not Valid ===>");
            return Product();
        }
    }

    [HttpPost("category/add")]
    public IActionResult AddCategory(Association association)
    {
        if (ModelState.IsValid)
        {
            int productId= association.ProductId;
            _context.Associations.Add(association);
            _context.SaveChanges();
            Console.WriteLine("Is Valid");
            return RedirectToAction("ShowProduct", new {productId=productId});
        }
        else
        {
            Console.WriteLine("Is InValid");
            return RedirectToAction("ShowProduct");
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}