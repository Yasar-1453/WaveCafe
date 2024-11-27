using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WaveCafe.DAL;
using WaveCafe.Models;

namespace WaveCafe.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductController : Controller
    {
        AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if(!ModelState.IsValid)
            {
                return View(product);
            }
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null) return NotFound();
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null) return NotFound();
            _context.Products.Remove(product);
            return View(product);
        }
        [HttpPost]
        public IActionResult Update(Product newProduct)
        {
            var oldCategory = _context.Products.FirstOrDefault(c => c.Id == newProduct.Id);
            if (oldCategory == null) return NotFound();

            oldCategory.Name = newProduct.Name;
            _context.SaveChanges();

            return RedirectToAction("Index");

            
        }
    }
}
