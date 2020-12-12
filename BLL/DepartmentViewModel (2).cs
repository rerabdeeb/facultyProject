using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BLL
{
    public class DepartmentsViewModel
    {
      [Key]
        [Display(Name = "Department ID")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Department Name Is Required")]
        [Display(Name = "Department Name")]
        public string DeptName { get; set; }
        [StringLength(3, ErrorMessage = "Department code is too long")]
        [Display(Name = "Code")]
        public string DeptCode { get; set; }


    }
}
