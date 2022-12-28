using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using System.Collections.Generic;
using WebApplicationEF1616.Models;


namespace WebApplicationEF1616.Controllers
{
    public class LinqExController : Controller
    {
        private readonly DataBasedbContext _context;
        public LinqExController(DataBasedbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AddLinkEx()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddLinkEx(LinqEx obj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Display", "LinqEx");
            }
            return View(obj);
        }
       
        [HttpGet]
        public IActionResult EDIT(int? ID)
        {
            if (ID == null)
            {
                return NotFound();
            }
            var data = _context.LINQEX.Find(ID);
            return View(data);
        }
        [HttpPost]
        public IActionResult EDIT(int ID, LinqEx LINQEX)
        {
            if (ModelState.IsValid)
            {
                _context.Update(LINQEX);
                _context.SaveChanges();
                return RedirectToAction("Display", "LinqEx");
            }
            return View();
        }
        public IActionResult DELETEDATA(int? ID)
        {
            var result = _context.LINQEX.Find(ID);
            if (result != null)
            {
                _context.LINQEX.Remove(result);
                _context.SaveChanges();
                return RedirectToAction("Display", "LinqEx");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Display()
        {
            //var res = from s in _context.LINQEX
            //          where s.NAME == "pavan"           //using QUERY SYNTAX
            //          select s;
            //return View(res.ToList());


            //var res1 = _context.LINQEX.Where(a => a.NAME == "pavan");  //using method syntax
            //return View(res1.ToList());

            //var res2 = _context.LINQEX.Where(a => a.ROLLNO == 1 );
            //return View(res2.ToList());


            //var res3 = from s in _context.LINQEX
            //           where s.ROLLNO == 1 && s.ROLLNO == 2        //using QUERY syntax
            //           select s;
            //return View(res3.ToList());

            //var res4 = from s in _context.LINQEX
            //           where s.ROLLNO>1
            //           select s;                                  //using query syntax
            //return View(res4.ToList());

            //var res5 = (from s in _context.LINQEX
            //           where s.MARKS > 30
            //           select s).Where(a => a.ROLLNO == 1);         //using MIXED MODE syntax
            //return View(res5.ToList());


            //IEnumerable<LinqEx> res6 = from std in _context.LINQEX
            //                                  where std.GENDER == "Male"  //using iEnumerable
            //                                    select std;
            //return View(res6.ToList());


            //IEnumerable<LinqEx> res7 = from std in _context.LINQEX
            //                           where std.GENDER == "FeMale"  //using iEnumerable
            //                           select std;
            //return View(res7.ToList());

            //IQueryable<LinqEx> res8 = from std in _context.LINQEX
            //                           where std.NAME=="ME"             //using iQUERYrable
            //                           select std;
            //return View(res8.ToList());

            //IEnumerable<LinqEx> res9= from std in _context.LINQEX
            //                           where std.NAME == "ME"            //using iEnumerable
            //                           select std;
            //return View(res9.ToList());


            //IEnumerable<LinqEx> res10 = from std in _context.LINQEX
            //                           where (std.ROLLNO %2==0)           //using iEnumerable with Extension method
            //                           select std;
            //return View(res10.ToList());


            //IEnumerable<LinqEx> res11 = from std in _context.LINQEX
            //                                                                //using select clause with query synatx
            //                            select std;
            //return View(res11.ToList());


            //var res1 = _context.LINQEX;                                       //using select clause with method syntax
            //return View(res1.ToList());



            //IEnumerable < LinqEx > res10 = from std in _context.LINQEX
            //                           where (std.ROLLNO %2==0)           //using iEnumerable with Extension method
            //                           select std;
            //return View(res10.ToList());



            //var res = (from std in _context.LINQEX

            //           select std).Distinct();
            //return View(res.ToList());


            //var res = from n in _context.LINQEX
            //          orderby n.NAME                   //order by asending
            //          select n;
            //return View(res);


            //var res = from n in _context.LINQEX
            //          orderby n.NAME descending                 //order by desnding
            //          select n;
            //return View(res);



            //var res1 = _context.LINQEX.OrderBy(x => x.NAME)
            //                           .ThenBy(x => x.NAME);  //using method syntax for thenby

            //return View(res1.ToList());



            //var res2 = from n in _context.LINQEX
            //             .OrderBy(x => x.NAME)
            //             .ThenBy(x => x.SURNAME) 
            //           select n;
            //return View(res2.ToList());


            //var res = (from n in _context.LINQEX
            //           select n).Sum(n=>n.ROLLNO);
            //return View(res.ToJson());

            //var res = _context.LINQEX.GroupBy(n => n.LUCKY);      // USING GROUP BY
            //return View(res.ToList());

            var res = from n in _context.LINQEX
                      orderby n.NAME                   //order by asending
                      select n;
            return View(res);

        }

    }
}
