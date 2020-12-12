using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModels;


namespace DAL

{
    interface ISubjectReposetory
    {

        bool Add(SubjectViewModel dept);
        bool Update(SubjectViewModel dept);
        bool Delete(int id);
        IEnumerable<SubjectViewModel> GetAll();

        SubjectViewModel GetByID(int id);

    }
   public class SubjectsReposatory:ISubjectReposetory
    {
       projectEntities context = new projectEntities();
        public bool Add(SubjectViewModel dept)
        {
            try
            {
                Subjects obj = new Subjects();
                obj.Code = dept.Code;
                obj.CreditHours = dept.CreditHours;
                obj.Day = dept.Day;
                obj.DeptID = dept.DeptID;
                
                obj.IsActive = dept.IsActive;
                obj.PreSubjectID = dept.PreSubjectID;
                obj.Subjects1 = dept.Subjects;
                obj.TimeFrome = dept.TimeFrome;
                obj.TimeTo = dept.TimeTo;
                
                
                context.Subjects.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }  
        }

        public bool Update(SubjectViewModel dept)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubjectViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public SubjectViewModel GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
