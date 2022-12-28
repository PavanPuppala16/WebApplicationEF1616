using Microsoft.AspNetCore.Mvc;
using WebApplicationEF1616.Models;

namespace WebApplicationEF1616.Controllers
{
    public class CountryStateController : Controller
    {
        private readonly DataBasedbContext _context;
        public CountryStateController(DataBasedbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddCountry()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCountry(countrystate obj)
        {
            country objcountry = new country();
            objcountry.cname = obj.cname;
            _context.country.Add(objcountry);
            _context.SaveChanges();

            state objstate = new state();
            objstate.sname = obj.sname;
            objstate.cid = objcountry.cid;
            _context.state.Add(objstate);
            _context.SaveChanges();
            return View();
        }
    }
}
