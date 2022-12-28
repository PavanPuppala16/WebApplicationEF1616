using Microsoft.AspNetCore.Mvc;
using WebApplicationEF1616.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationEF1616.Controllers
{
    public class EmpOneToManyController : Controller
    {

        private readonly DataBasedbContext _context;
        public EmpOneToManyController(DataBasedbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AddNewEmployee()
        {
            ViewBag.Bank = new SelectList(_context.Bank, "BankID", "BankName");
            return View();
        }
        [HttpPost]
        public IActionResult AddNewEmployee(Employee obj)
        {
            _context.Employee.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("AddNewEmployee");

        }
        [HttpGet]
        //public IActionResult GetEmpData()
        //{  var res = _context.Employee.ToList();
        //    var result = (from s in _context.Employee select s) .Include(x => x.Bank).ToList(); 
        //    return View(result);
        //}
        public IActionResult GetEmpData2()
        {
            var res = _context.Employee.ToList();
            var result = (from s in _context.Employee select s).Include(x => x.Bank).ToList();
            return View(result);
        }

    }
        }

