using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModels;


namespace DAL
{
    interface ILevelsReposetory
    {

        bool Add(LevelsViewModel dept);
        bool Update(LevelsViewModel dept);
        bool Delete(int id);
        IEnumerable<LevelsViewModel> GetAll();

        LevelsViewModel GetByID(int id);

    }
    public class LevelsReposatory:ILevelsReposetory
    {
        projectEntities context = new projectEntities();
        public bool Add(LevelsViewModel lev)
        {
            try
            {
                Level obj = new Level();
                obj.Level1 = lev.Level;
                context.Levels.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }  
        }

        public bool Update(LevelsViewModel dept)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LevelsViewModel> GetAll()
        {
            List<LevelsViewModel> levs = new List<LevelsViewModel>();
            foreach (var item in context.Levels)
            {
                LevelsViewModel obj = new LevelsViewModel();
                obj.ID = item.ID;
                obj.Level = item.Level1;

                levs.Add(obj);
            }
            return levs;
           
        }

        public LevelsViewModel GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
