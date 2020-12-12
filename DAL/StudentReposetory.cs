using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModels;
using System.Data.Entity.Core.Objects;


namespace DAL
{
    interface IStudentReposetory
    {

        bool Add(StudentViewModel stud);
        bool Update(StudentViewModel dept);
        bool Delete(int id);
        IEnumerable<StudentViewModel> GetAll();
        IEnumerable<StudentViewModel> GetAllDepartment();
        StudentViewModel GetByID(int id);
        string FullName(int id);
        bool checkUserName(decimal nationalID, string password);
        bool checkPassword(StudentViewModel stud);
        int getID(decimal nationalID);


    }
    public class StudentReposetory : IStudentReposetory
    {
        projectEntities context = new projectEntities();
          [ValidateAntiForgeryToken]
        public bool Add(StudentViewModel stud)
        {
            try
            {
      context.InsertDataStudent(stud.LevelID, stud.NationalID, stud.Mobile, stud.Password,
      stud.FirstName, stud.MiddleName, stud.SurName, stud.DeptID, stud.Image, true, stud.GenderID);
                //Student std = new Student();
                
                
                //    Student obj = new Student();
                //    Dept obj2 = new Dept();
                //    obj.FirstName = stud.FirstName;
                //    obj.MiddleName = stud.MiddleName;
                //    obj.NationalID = stud.NationalID;
                //    obj.Mobile = stud.Mobile;
                //    obj.Password = stud.Password;
                //    obj.SurName = stud.SurName;
                //    obj.DeptID = stud.DeptID;
                //    obj.GenderID = stud.GenderID;
                //    obj.Image = stud.Image;
                //    obj.LevelID = stud.LevelID;
                //    context.Student.Add(obj);
                //    context.SaveChanges();
                    return true;
                
                
            }
            catch
            {
                return false;
            }
        }

        public bool Update(StudentViewModel dept)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentViewModel> GetAll()
        {
            List<StudentViewModel> stu = new List<StudentViewModel>();
            foreach (var item in context.Student)
            {
                StudentViewModel obj = new StudentViewModel();
                obj.ID = item.ID;
                obj.FirstName = item.FirstName;
                obj.MiddleName = item.MiddleName;
                obj.SurName = item.SurName;
                obj.Image = item.Image;
                obj.NationalID = item.NationalID;
                obj.Password = item.Password;
                obj.Mobile = item.Mobile;
                obj.Name = FullName(item.ID);
                foreach (var item2 in context.Dept)
                {
                    if (item.DeptID == item2.ID)
                    {
                        obj.depts = item2.DeptName;

                    }


                }
                stu.Add(obj);
            }
            return stu;
        }


        public StudentViewModel GetByID(int id)
        {
            Student stu = context.Student.FirstOrDefault(x => x.ID == id);
            StudentViewModel obj = new StudentViewModel();
            obj.ID = stu.ID;
            obj.DeptID = stu.DeptID;
            obj.GenderID = stu.GenderID;
            obj.FirstName = stu.FirstName;
            obj.MiddleName = stu.MiddleName;
            obj.SurName = stu.SurName;
            obj.Image = stu.Image;
            obj.NationalID = stu.NationalID;
            obj.Password = stu.Password;
            obj.LevelID = stu.LevelID;
            obj.Mobile = stu.Mobile;

            return obj;
        }


        public string FullName(int id)
        {
            string firstName = context.Student.Where(x => x.ID == id).Select(x => x.FirstName).FirstOrDefault();
            string MiddleName = context.Student.Where(x => x.ID == id).Select(x => x.MiddleName).FirstOrDefault();
            string surName = context.Student.Where(x => x.ID == id).Select(x => x.SurName).FirstOrDefault();

            string FullName = firstName + " " + MiddleName + " " + surName;
            return FullName;
        }






        public IEnumerable<StudentViewModel> GetAllDepartment()
        {
            List<StudentViewModel> db = new List<StudentViewModel>();

            foreach (var item in context.Dept)
            {
                StudentViewModel obj = new StudentViewModel();
                obj.DeptID = item.ID;
                obj.depts = item.DeptName;
                db.Add(obj);
            }
            return db;
        }





        public bool checkPassword(StudentViewModel stud)
        {
            throw new NotImplementedException();
        }




         [ValidateAntiForgeryToken]
        public bool checkUserName(decimal nationalID, string password)
        {
            //StudentViewModel st = new StudentViewModel();
            //st.Password = password;
            //st.NationalID = nationalID;
            try {
              //var x=context.CheckLogin(nationalID, password);
              //if (x.Equals("true"))
              //    return true;
              //  else
              //    return false;
              List<Student> stu = new List<Student>();
              Student std = new Student();
              foreach (var item in context.Student)
              {
                  StudentViewModel obj = new StudentViewModel();
                  if (item.NationalID == nationalID)
                  {
                      stu.Add(item);
                  }

              }

              foreach (var item2 in stu)
              {
                  if (item2.Password == password)
                  return true;
                  else
                      return false;
              }
              return true;
            }
            catch
            {
                return false;
            }

        }


         public int getID(decimal nationalID)
         {
             List<StudentViewModel> db = new List<StudentViewModel>();
             List<Student> stu = new List<Student>();
             StudentViewModel obj = new StudentViewModel();
             foreach (var item in context.Student)
             {
                 if (item.NationalID == nationalID){
                     obj.ID = item.ID;
                     
                 }

                 
             }
             return obj.ID;
         }
    }
}
            
        
        
    
   
