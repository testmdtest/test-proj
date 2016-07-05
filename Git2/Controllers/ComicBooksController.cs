using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Git2.Controllers
{
    public class ComicBooksController : Controller
    {
        //
        // GET: /ComicBooks/
        public ActionResult Detail()
        {
             ViewBag.seriesTitle = "Test1";
               ViewBag.num = 700;
    // string array is object, have to new up
            ViewBag.artists= new string[]{
                                "der", "derder"  
                                };



            return View("Detail2");
            // convention-named view
        }
	}
}