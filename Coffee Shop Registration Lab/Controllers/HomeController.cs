using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Coffee_Shop_Registration_Lab.Models;

namespace Coffee_Shop_Registration_Lab.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private CoffeeDbContext dbContext = new CoffeeDbContext();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Product> result = dbContext.Products.ToList();
        return View(result);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Form()
    {
        return View();
    }

    public IActionResult Result(Registration u)
    {
        return View(u);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

