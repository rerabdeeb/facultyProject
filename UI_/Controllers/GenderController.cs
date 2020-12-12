using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BLL;
using UI_.Models;

namespace UI_.Controllers
{
    public class GenderController : Controller
    {
        private UI_Context db = new UI_Context();

        // GET: /Gender/
        public ActionResult Index()
        {
            return View(db.GenderViewModels.ToList());
        }

        // GET: /Gender/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GenderViewModel genderviewmodel = db.GenderViewModels.Find(id);
            if (genderviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(genderviewmodel);
        }

        // GET: /Gender/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Gender/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Gender1,IsActive")] GenderViewModel genderviewmodel)
        {
            if (ModelState.IsValid)
            {
                db.GenderViewModels.Add(genderviewmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(genderviewmodel);
        }

        // GET: /Gender/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GenderViewModel genderviewmodel = db.GenderViewModels.Find(id);
            if (genderviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(genderviewmodel);
        }

        // POST: /Gender/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Gender1,IsActive")] GenderViewModel genderviewmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(genderviewmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(genderviewmodel);
        }

        // GET: /Gender/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GenderViewModel genderviewmodel = db.GenderViewModels.Find(id);
            if (genderviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(genderviewmodel);
        }

        // POST: /Gender/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GenderViewModel genderviewmodel = db.GenderViewModels.Find(id);
            db.GenderViewModels.Remove(genderviewmodel);
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
