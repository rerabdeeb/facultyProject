using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModels;

namespace DAL
{
    interface IGenderReposetory
    {
        
        bool Add(GenderViewModel dept);
        bool Update(GenderViewModel dept);
        bool Delete(int id);
        IEnumerable<GenderViewModel> GetAll();
        
        GenderViewModel GetByID(int id);

    }
   public class GenderReposetory:IGenderReposetory
    {
       projectEntities context = new projectEntities();
        public bool Add(GenderViewModel Gen)
        {
            try
            {
                Gender obj = new Gender();
                obj.Gender1 = Gen.Gender1;
                context.Genders.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }  
        }

        public bool Update(GenderViewModel dept)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenderViewModel> GetAll()
        {
            List<GenderViewModel> Gend = new List<GenderViewModel>();
            foreach (var item in context.Genders)
            {
                GenderViewModel obj = new GenderViewModel();
                obj.Id = item.Id;
                obj.Gender1 = item.Gender1;

                Gend.Add(obj);
            }
            return Gend;
        }
        

        public GenderViewModel GetByID(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
