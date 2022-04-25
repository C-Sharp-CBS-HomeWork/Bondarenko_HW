using Microsoft.AspNetCore.Mvc;
using Task2.Models;

namespace Task2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductReader _reader;

        public ProductsController()
        {
            _reader = new ProductReader();
        }

        // Products/List/tech

        public IActionResult List(string? category)
        {
            List<Product> products = _reader.ReadFromFile();
            if (category is null)
                return View(products);
            else
            {
                products = products.Where(x => x.Category == category).ToList();
                return View(products);
            }   
        }

        // Products/Details/1
        public IActionResult Details(int id)
        {
            List<Product> products = _reader.ReadFromFile();
            Product product = products.Where(x => x.Id == id).FirstOrDefault();

            if (product != null)
            {
                return View(product);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
