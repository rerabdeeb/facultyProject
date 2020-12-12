using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModels;


namespace DAL
{
    interface IProfessorSubjectReposetory
    {

        bool Add(ProfessorSubjectsViewModel dept);
        bool Update(ProfessorSubjectsViewModel dept);
        bool Delete(int id);
        IEnumerable<ProfessorSubjectsViewModel> GetAll();

        ProfessorSubjectsViewModel GetByID(int id);

    }
    public class ProfessorSubjectsReposatory:IProfessorSubjectReposetory
    {
        projectEntities context = new projectEntities();
        public bool Add(ProfessorSubjectsViewModel sub)
        {
            try
            {
                ProfessorSubject obj = new ProfessorSubject();
                obj.professorID = sub.professorID;
                obj.SubjectID = sub.SubjectID;
                context.ProfessorSubjects.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }  
        }

        public bool Update(ProfessorSubjectsViewModel dept)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProfessorSubjectsViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProfessorSubjectsViewModel GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
