using Microsoft.AspNetCore.Mvc;
using WebApplicationEF1616.Models;


namespace WebApplicationEF1616.Controllers
{
    public class EMPLOYEEFController : Controller
    {

        private readonly DataBasedbContext _context;
        public EMPLOYEEFController(DataBasedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(TB_EFEMPLOYE obj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Display", "Product");
            }
            return View(obj);
        }
        public IActionResult Display()
        {
            return View();
        }
    }
}
