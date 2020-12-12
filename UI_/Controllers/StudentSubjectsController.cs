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
    public class StudentSubjectsController : Controller
    {
        private UI_Context db = new UI_Context();

        // GET: /StudentSubjects/
        public ActionResult Index()
        {
            return View(db.StudentSubjectsViewModels.ToList());
        }

        // GET: /StudentSubjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentSubjectsViewModel studentsubjectsviewmodel = db.StudentSubjectsViewModels.Find(id);
            if (studentsubjectsviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(studentsubjectsviewmodel);
        }

        // GET: /StudentSubjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /StudentSubjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,StudentID,SubjectID,IsPassed")] StudentSubjectsViewModel studentsubjectsviewmodel)
        {
            if (ModelState.IsValid)
            {
                db.StudentSubjectsViewModels.Add(studentsubjectsviewmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentsubjectsviewmodel);
        }

        // GET: /StudentSubjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentSubjectsViewModel studentsubjectsviewmodel = db.StudentSubjectsViewModels.Find(id);
            if (studentsubjectsviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(studentsubjectsviewmodel);
        }

        // POST: /StudentSubjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,StudentID,SubjectID,IsPassed")] StudentSubjectsViewModel studentsubjectsviewmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentsubjectsviewmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentsubjectsviewmodel);
        }

        // GET: /StudentSubjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentSubjectsViewModel studentsubjectsviewmodel = db.StudentSubjectsViewModels.Find(id);
            if (studentsubjectsviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(studentsubjectsviewmodel);
        }

        // POST: /StudentSubjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentSubjectsViewModel studentsubjectsviewmodel = db.StudentSubjectsViewModels.Find(id);
            db.StudentSubjectsViewModels.Remove(studentsubjectsviewmodel);
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
