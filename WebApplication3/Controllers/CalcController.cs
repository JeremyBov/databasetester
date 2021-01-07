using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new calc());
        }
        [HttpPost]
        public ActionResult Index(calc c,string calculate)
        {

            if (calculate == "add") 
            {
                c.tot = c.no1 + c.no2;
            }
            else if (calculate == "min")
            {
                c.tot = c.no1 - c.no2;
            }
            else if (calculate == "sub")
            {
                c.tot = c.no1 * c.no2;
            }
            else if (calculate == "divv")
            {
                c.tot = c.no1 / c.no2;
            }
            else if (calculate == "equals")
            {
                int x = 0;
                Int32.TryParse(c.area, out x);
                int x2 = Int32.Parse(c.area);
                c.area = (x).ToString();
                return View(c);
            }




            if (c.tot == 69) 
            { c.truetotal = "nice";
                return View(c);
            }
            if (c.tot == 420)
            {
                c.truetotal = "smoke weed everyday";
                return View(c);
            }
            if (c.tot == 34)
            {
                c.truetotal = "appie noerie";
                return View(c);
            }
            c.truetotal = (c.tot).ToString();
            return View(c);


        }
    }
}