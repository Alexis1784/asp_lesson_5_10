using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_lesson_5_10.Models;

namespace asp_lesson_5_10.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        BookContext db = new BookContext();

        [HttpGet]
        public ActionResult Add()
        {
            return View(db.Books.ToList());
        }
        [HttpPost]
        public string Add(List<Book> books)
        {
            db.Books.AddRange(books);
            db.SaveChanges();
            return "done!";
        }
        [HttpGet]
        public ActionResult Array()
        {
            Book firstBook = db.Books.ToList<Book>().FirstOrDefault();
            return View(firstBook);
        }
        [HttpPost]
        public string Array(Book book, Book myBook)
        {
            return "Array done";
        }
    }
}