using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModels;


namespace DAL
{
    interface IProfessorReposetory
    {

        bool Add(ProfessorViewModel dept);
        bool Update(ProfessorViewModel dept);
        bool Delete(int id);
        IEnumerable<ProfessorViewModel> GetAll();

        ProfessorViewModel GetByID(int id);

    }
    public class ProfessorReposatory:IProfessorReposetory
    {
        projectEntities context = new projectEntities();

        public bool Add(ProfessorViewModel prof)
        {
            try
            {
                Professor obj = new Professor();
                obj.Name = prof.Name;
                obj.image = prof.image;

                context.Professors.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }  
        }

        public bool Update(ProfessorViewModel dept)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProfessorViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProfessorViewModel GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
