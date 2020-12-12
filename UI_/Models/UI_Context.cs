using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UI_.Models
{
    public class UI_Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public UI_Context() : base("name=UI_Context")
        {
        }

        public System.Data.Entity.DbSet<BLL.StudentViewModel> StudentViewModels { get; set; }

        public System.Data.Entity.DbSet<BLL.SubjectViewModel> SubjectViewModels { get; set; }

        public System.Data.Entity.DbSet<BLL.GenderViewModel> GenderViewModels { get; set; }

        public System.Data.Entity.DbSet<BLL.StudentSubjectsViewModel> StudentSubjectsViewModels { get; set; }
    
    }
}
