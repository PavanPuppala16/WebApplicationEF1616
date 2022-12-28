using Microsoft.AspNetCore.Mvc;
using WebApplicationEF1616.Models;

namespace WebApplicationEF1616.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataBasedbContext _context;
        public ProductController(DataBasedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddProducts()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProducts(PRODUCT obj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Display", "Product");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Display()
        {
            var res = from s in _context.PRODUCT
                      where s.PNAME == "APPEL"
                      select s;
            return View(res.ToList());

        }
        [HttpGet]
        public IActionResult EDIT(int? PID)
        {
            if (PID == null)
            {
                return NotFound();
            }
            var data = _context.PRODUCT.Find(PID);
            return View(data);
        }
        [HttpPost]
        public IActionResult EDIT(int PID, PRODUCT product)
        {
            if (ModelState.IsValid)
            {
                _context.Update(product);
                _context.SaveChanges();
                return RedirectToAction("Display", "PRODUCT");
            }
            return View();
        }

        public IActionResult DELETEDATA(int? PID)
        {
            var result = _context.PRODUCT.Find(PID);
            if (result != null)
            {
                _context.PRODUCT.Remove(result);
                _context.SaveChanges();
                return RedirectToAction("Display", "PRODUCT");
            }
            return View();
        }
    }


}
