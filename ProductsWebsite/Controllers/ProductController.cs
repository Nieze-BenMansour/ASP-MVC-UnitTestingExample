using Microsoft.AspNetCore.Mvc;
using ProductsWebsite.Models;
using ProductsWebsite.Repositories;

namespace ProductsWebsite.Controllers;

public class ProductController : Controller
{
    private IProductRepository _repository;
    private readonly ILogger<ProductController> _logger;

    public ProductController(IProductRepository repository, ILogger<ProductController> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public IActionResult Index()
    {
        IEnumerable<Product> products = new List<Product>();
        try
        {
             products = _repository.GetProducts();
            return View(products);
        }
        catch (ArgumentNullException ex)
        {
            _logger.LogError(ex.Message, ex);
            return BadRequest("Le param a été null pour la liste");
        }
        finally 
        {
            _logger.LogInformation($"Voici la liste: {products}");
        }
    }

    public IActionResult GetProduct(int id)
    {
        var products = _repository.GetProducts();
        var product = products.Where(p => p.Id == id).FirstOrDefault();
        return View(product);
    }

    public IActionResult GetImage(string name)
    {
        return File($@"images\{name}.png", "image/png");
    }
}