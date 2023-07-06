using LibraryManagementSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class AuthorController : Controller
    {
        DbLibEntities db = new DbLibEntities();
        public ActionResult Index()
        {
            var values = db.TblAuthor.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult AddAuthor(TblAuthor p)
        {
            db.TblAuthor.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RemoveAuthor(int id)
        {
            var author = db.TblAuthor.Find(id);
            db.TblAuthor.Remove(author);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetAuthor(int id )
        {
            var author = db.TblAuthor.Find(id);
            return View("GetAuthor", author);
        }

        public ActionResult UpdateAuthor(TblAuthor P)
        {
            var author = db.TblAuthor.Find(P.ID);
            author.Name = P.Name;
            author.Surname = P.Surname;
            author.Detail = P.Detail;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}