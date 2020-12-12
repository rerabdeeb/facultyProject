using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
    public class SubjectViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Subjects Is Required")]
        [Display(Name = "Subjects")]
        public string Subjects { get; set; }
        
        [Required(ErrorMessage = "CreditHours Is Required")]
        [Display(Name = "Credit Hours")]

        public Nullable<double> CreditHours { get; set; }
        [Required(ErrorMessage = "Code Is Required")]
        [Display(Name = "Code")]

        public string Code { get; set; }

        public Nullable<bool> IsActive { get; set; }

        public Nullable<int> DeptID { get; set; }
        public Nullable<int> PreSubjectID { get; set; }
        public string Day { get; set; }
        [Required(ErrorMessage = "TimeFrome Is Required")]
        [Display(Name = "Time Frome")]

        public Nullable<double> TimeFrome { get; set; }
        [Required(ErrorMessage = "TimeTo Is Required")]
        [Display(Name = "Time To")]

        public Nullable<double> TimeTo { get; set; }
    }
}
