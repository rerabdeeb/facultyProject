using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BLL;
using DataModels;
using DAL;

namespace UI.Controllers
{
    public class StudentController : Controller
    {
        StudentReposetory repo = new StudentReposetory();
        DepartmentReposetory repo2 = new DepartmentReposetory();
        LevelsReposatory repo3 = new LevelsReposatory();
        GenderReposetory repo4 = new GenderReposetory();
        // GET: /Student/
        
        
        public ActionResult Index()
        {

            

            return View();
        }
        
        

        public ActionResult Details(int? id)
        {

            return View();
        }
       
        
        public ActionResult GetDepts()
        {
            IEnumerable<StudentViewModel> dept = repo.GetAllDepartment();
            return View(dept);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Create1(StudentViewModel student)
        {

            if (repo.Add(student))
            {
                return Json("Success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Failed", JsonRequestBehavior.AllowGet);

            }
        }
        
        
        public JsonResult GetAllLevels()
        {
            IEnumerable<LevelsViewModel> levels = repo3.GetAll();

            return Json(levels, JsonRequestBehavior.AllowGet);
        }
        
        
        public JsonResult GetAllDepartment()
        {
            IEnumerable<DepartmentsViewModel> Departments = repo2.GetAll();
            return Json(Departments, JsonRequestBehavior.AllowGet);
        }
      
        
        public JsonResult GetAllGender()

        {
            IEnumerable<GenderViewModel> Departments = repo4.GetAll();
            return Json(Departments, JsonRequestBehavior.AllowGet);
        }


        public JsonResult Add(StudentViewModel std)
        {
            bool x = repo.Add(std);
            if(x==true)
                return Json("Success", JsonRequestBehavior.AllowGet);
            else 
                return Json("Failed", JsonRequestBehavior.AllowGet);
        }
        public ActionResult ResisterSubject()
        {

            return View();
        }
        
       
        public ActionResult login()
        {
            return View();
        }

        public JsonResult login1(decimal nationalID, string pass)
        {
            bool x = repo.checkUserName(nationalID, pass);
            if (x == true)
            {

                var name = repo.FullName(repo.getID(nationalID));
                ViewBag.message = "Welcome" + name;
                return Json("Success", JsonRequestBehavior.AllowGet); 
            }
            else
            {
                //ViewBag.message = "Wrong password or email" + user;
                return Json("Failed", JsonRequestBehavior.AllowGet);
            }

        }
        // POST: /Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        


        // GET: /Student/Edit/5
        public ActionResult Edit(int? id)
        {

            return View();
        }

        // POST: /Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LevelID,NationalID,Mobile,Password,FirstName,MiddleName,SurName,Name,DeptID,GenderID,Image,IsActive,DepartmentName,Gender,Levels,StudentsSubjects")] StudentViewModel studentviewmodel)
        {

            return View();
        }

        // GET: /Student/Delete/5
        public ActionResult Delete(int? id)
        {

            return View();
        }

        // POST: /Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            return RedirectToAction("Index");
        }


    }
}
