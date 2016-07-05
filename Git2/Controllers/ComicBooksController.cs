using Git2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Git2.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepo _comicRepo = null;

        public ComicBooksController()
        {
            _comicRepo = new ComicBookRepo();
            //init membs in 
        }

        public ActionResult Index()
        {
            var comics = _comicRepo.GetComics();

            return View(comics);
        }

        //
        // GET: /ComicBooks/
        public ActionResult Detail(int? id)
        {//nullable arg type

            if (id == null)
            {
                return HttpNotFound();
            }

            //var comicBkRepo = new ComicBookRepo();
            // use val p[rop or cast
            var comic = _comicRepo.getComicBook(id.Value);

            return View( comic);

            //default to index.cshtml

            // convention-named view
        }
	}
}