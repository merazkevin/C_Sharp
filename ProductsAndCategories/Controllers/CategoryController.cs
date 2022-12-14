using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductsAndCategories.Models;
using Microsoft.EntityFrameworkCore;
namespace ProductsAndCategories.Controllers;
using Microsoft.AspNetCore.Mvc.ModelBinding;


public class CategoryController : Controller
{
    private MyContext _context;

    public CategoryController(MyContext context)
    {
        _context = context;
    }

    //TODO <=== Get Routes ===>
    [HttpGet("category")]
    public IActionResult Category()
    {
        List<Category> AllCategories = _context.Categories.Include(e => e.Associations).ThenInclude(e => e.Product).ToList();
        CategoryViews categoryViews = new CategoryViews();
        categoryViews.Categories = AllCategories;
        return View("Category", categoryViews);
    }

    [HttpGet("category/{categoryId}")]
    public IActionResult ShowCategory(int categoryId)
    {
        ViewBag.Products = _context.Products.ToList();
        CategoryViews oneCategoryWithProduct = new CategoryViews();
        Category? oneCategory = _context.Categories
                .Include(e => e.Associations)
                .ThenInclude(e => e.Product)
                .FirstOrDefault(e => e.CategoryId == categoryId);
        oneCategoryWithProduct.Category = oneCategory;
        return View("showCategory", oneCategoryWithProduct);
    }



    //TODO <=== Post Routes ===>
    [HttpPost("category/create")]
    public IActionResult CreateCategory(Category newCategory)
    {
        
        if (ModelState.IsValid)
        {
            Console.WriteLine(newCategory.Name);
            Console.WriteLine("<=== Is Valid ===>");
            _context.Add(newCategory);
            _context.SaveChanges();
            return RedirectToAction("Category");
        }
        else
        {
            Console.WriteLine("<=== Is Invalid ===>");
            return Category();
        }
    }

    [HttpPost("product/add")]
    public IActionResult AddProduct(Association association)
    {
        if (ModelState.IsValid)
        {
            int categoryId = association.CategoryId;
            _context.Associations.Add(association);
            _context.SaveChanges();
            Console.WriteLine("Is Valid");
            return RedirectToAction("ShowCategory", new { categoryId = categoryId });
        }
        else
        {
            Console.WriteLine("Is Invalid");
            return View("ShowCategory", association.CategoryId);
        }
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
