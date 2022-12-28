using Microsoft.AspNetCore.Mvc;
using WebApplicationEF1616.Models;

namespace WebApplicationEF1616.Controllers
{
    public class countrystatedistController : Controller
    {
        private readonly DataBasedbContext _context;
        public countrystatedistController(DataBasedbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Addcountry()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCountry(countrystatedist obj)
        {
            country1 objcountry1 = new country1();
            objcountry1.cname = obj.cname;
            _context.country1.Add(objcountry1);
            _context.SaveChanges();

            state1 objstate1 = new state1();
            objstate1.sname = obj.sname;
            objstate1.cid = objcountry1.cid;
            _context.state1.Add(objstate1);
            _context.SaveChanges();
        

            dist objdist = new dist();
            objdist.dname = obj.dname;
            objdist.cid = objcountry1.cid;
            _context.dist.Add(objdist);
            _context.SaveChanges();
            return View();

        }
    }
}
