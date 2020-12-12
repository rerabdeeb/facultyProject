using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModels;


namespace DAL
{
    interface IStudentSubjectReposetory
    {

        bool Add(StudentSubjectsViewModel dept);
        bool Update(StudentSubjectsViewModel dept);
        bool Delete(int id);
        IEnumerable<StudentSubjectsViewModel> GetAll();

        StudentSubjectsViewModel GetByID(int id);

    }
   public class StudentSubjectsReposatory:IStudentSubjectReposetory
    {
       projectEntities context = new projectEntities();
        public bool Add(StudentSubjectsViewModel stuS)
        {
            try
            {
                StudentsSubjects obj = new StudentsSubjects();
                obj.ID = stuS.ID;
                obj.IsPassed = stuS.IsPassed;
                obj.StudentID = stuS.StudentID;
                obj.SubjectID = stuS.SubjectID;
                
                context.StudentsSubjects.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }  
        }

        public bool Update(StudentSubjectsViewModel dept)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentSubjectsViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public StudentSubjectsViewModel GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
