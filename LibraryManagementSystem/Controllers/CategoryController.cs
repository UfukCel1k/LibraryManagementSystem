using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models.Entity;

namespace LibraryManagementSystem.Controllers
{

    public class CategoryController : Controller
    {
        DbLibEntities db = new DbLibEntities();
        public ActionResult Index()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategory( )
        {
            return View();
        }
        [HttpPost]  
        public ActionResult AddCategory(TblCategory p)
        {
            db.TblCategory.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RemoveCategory(int id)
        {
            var category = db.TblCategory.Find(id);
            db.TblCategory.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult GetCategory(int id)
        {
            var category = db.TblCategory.Find(id);
            return View("GetCategory", category);
        }

        public ActionResult UpdateCategory(TblCategory p)
        {
            var category = db.TblCategory.Find(p.ID);
            category.Name = p.Name;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}