using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
    public class StudentSubjectsViewModel
    {
        public int ID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public Nullable<bool> IsPassed { get; set; }

    }
}
