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
    public class SubjectController : Controller
    {
        private UI_Context db = new UI_Context();

        // GET: /Subject/
        public ActionResult Index()
        {
            return View(db.SubjectViewModels.ToList());
        }

        // GET: /Subject/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectViewModel subjectviewmodel = db.SubjectViewModels.Find(id);
            if (subjectviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(subjectviewmodel);
        }

        // GET: /Subject/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Subject/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Subjects,CreditHours,Code,IsActive,DeptID,PreSubjectID,Day,TimeFrome,TimeTo")] SubjectViewModel subjectviewmodel)
        {
            if (ModelState.IsValid)
            {
                db.SubjectViewModels.Add(subjectviewmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subjectviewmodel);
        }

        // GET: /Subject/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectViewModel subjectviewmodel = db.SubjectViewModels.Find(id);
            if (subjectviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(subjectviewmodel);
        }

        // POST: /Subject/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Subjects,CreditHours,Code,IsActive,DeptID,PreSubjectID,Day,TimeFrome,TimeTo")] SubjectViewModel subjectviewmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subjectviewmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subjectviewmodel);
        }

        // GET: /Subject/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectViewModel subjectviewmodel = db.SubjectViewModels.Find(id);
            if (subjectviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(subjectviewmodel);
        }

        // POST: /Subject/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubjectViewModel subjectviewmodel = db.SubjectViewModels.Find(id);
            db.SubjectViewModels.Remove(subjectviewmodel);
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
