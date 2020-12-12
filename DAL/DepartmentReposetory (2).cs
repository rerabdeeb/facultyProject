using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModels;
namespace DAL
    
{
    interface IDepartmentReposetory
    {
        
        bool Add(DepartmentsViewModel dept);
        bool Update(DepartmentsViewModel dept);
        bool Delete(int id);
        IEnumerable<DepartmentsViewModel> GetAll();
        string DeptCode(int id);
        DepartmentsViewModel GetByID(int id);
        
    }
     public class DepartmentReposetory:IDepartmentReposetory
    {
        projectEntities context = new projectEntities();



        public bool Add(DepartmentsViewModel dept)
        {
            try
            {
                Dept obj = new Dept();
                obj.DeptName = dept.DeptName;
                context.Depts.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }  
        }

        public bool Update(DepartmentsViewModel dept)
        {
            try {

                Dept obj = context.Depts.FirstOrDefault(x => x.ID == dept.ID);
                if (obj != null)
                {
                    obj.DeptName = dept.DeptName;
                    context.SaveChanges();
                    return true;
                }
                else
                    return false;
               
            }
            catch(Exception)
            {
                return false;
            }
            
        }

        public bool Delete(int id)
        {

            try
            {
                if (id > 0)
                {
                    Dept obj = context.Depts.FirstOrDefault(x => x.ID == id);

                    if (obj != null)
                    {
                        context.Depts.Remove(obj);
                        context.SaveChanges();
                        return true;

                    }
                    else
                        return false;
                    
                }
                else
                    return false;   

                }
                catch(Exception){
                    return false;
                }


            
        }

        public IEnumerable<DepartmentsViewModel> GetAll()
        {
            List<DepartmentsViewModel> depts = new List<DepartmentsViewModel>();
            foreach (var item in context.Depts)
            {
                DepartmentsViewModel obj = new DepartmentsViewModel();
                obj.ID = item.ID;
                obj.DeptName = item.DeptName;
                obj.DeptCode = DeptCode(item.ID);
                depts.Add(obj);
            }
            return depts;
        }

        public string DeptCode(int id)
        {
            string deptName = context.Depts.Where(x => x.ID == id).Select(x => x.DeptName).FirstOrDefault();
            string[] words = deptName.Split(new char[] { ' ' });
            string code = "";
            foreach (var item in words)
            {
                code += item.Substring(0, 1);
            }
            return code;
        }
        public DepartmentsViewModel GetByID(int id)
        {
            Dept dept = context.Depts.FirstOrDefault(x => x.ID == id);
            DepartmentsViewModel obj = new DepartmentsViewModel();
            obj.ID = dept.ID;
            obj.DeptName = dept.DeptName;
            obj.DeptCode = DeptCode(dept.ID);
            return obj;
        }
    }
}
