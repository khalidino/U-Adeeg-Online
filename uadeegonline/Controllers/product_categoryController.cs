using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using uadeegonline.Models;

namespace uadeegonline.Controllers
{
    public class product_categoryController : Controller
    {
        private uadeegonlineEntities db = new uadeegonlineEntities();

        // GET: product_category
        public ActionResult Index()
        {
            return View(db.product_category.ToList());
        }

        public ActionResult listcategory()
        {
            return View(db.product_category.ToList());
        }

        // GET: product_category/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product_category product_category = db.product_category.Find(id);
            if (product_category == null)
            {
                return HttpNotFound();
            }
            return View(product_category);
        }

        // GET: product_category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: product_category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cat_id,cat_name,cat_desc")] product_category product_category)
        {
            if (ModelState.IsValid)
            {
                db.product_category.Add(product_category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product_category);
        }

        // GET: product_category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product_category product_category = db.product_category.Find(id);
            if (product_category == null)
            {
                return HttpNotFound();
            }
            return View(product_category);
        }

        // POST: product_category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cat_id,cat_name,cat_desc")] product_category product_category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product_category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product_category);
        }

        // GET: product_category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product_category product_category = db.product_category.Find(id);
            if (product_category == null)
            {
                return HttpNotFound();
            }
            return View(product_category);
        }

        // POST: product_category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            product_category product_category = db.product_category.Find(id);
            db.product_category.Remove(product_category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
