using Microsoft.AspNetCore.Mvc;
using WebApplicationEF1616.Models;

namespace WebApplicationEF1616.Controllers
{
    public class EFStudentController : Controller
    {
        private readonly DataBasedbContext _context;
        public EFStudentController(DataBasedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(TB_EFSTUDENT obj)
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
