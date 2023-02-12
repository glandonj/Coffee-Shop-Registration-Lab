using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Coffee_Shop_Registration_Lab.Controllers
{
    public class ProductController : Controller
    {
        // GET: /<controller>/
        private CoffeeDbContext dbContext = new CoffeeDbContext();

        public IActionResult Index()
        {
            List<Product> result = dbContext.Products.ToList();
            return View(result);
        }
        public IActionResult ProductDetails(int id)
        {
            Product result = dbContext.Products.FirstOrDefault(c => c.Id == id);
            return View(result);
        }

        public IActionResult ProductView()
        {
            List<Product> result = dbContext.Products.ToList();
            return View(result);
        }

        public IActionResult BlackProducts()
        {
            List<Product> result = dbContext.Products.ToList();
            return View(result);
        }

        public IActionResult MilkProducts()
        {
            List<Product> result = dbContext.Products.ToList();
            return View(result);
        }
    }
}

