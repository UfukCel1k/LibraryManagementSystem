using LibraryManagementSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class BookController : Controller
    {
        DbLibEntities db = new DbLibEntities();

        public ActionResult Index()
        {
            var book = db.TblBook.ToList();
            return View(book);
        }

        [HttpGet]
        public ActionResult AddBook()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddBook(TblBook p)
        {

            return View();
        }
    }
}