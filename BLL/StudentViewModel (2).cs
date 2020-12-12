using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL
{
    public class StudentViewModel
    {
        [Key]
        public int ID { get; set; }
        
        
        
        [Required(ErrorMessage = "FirstName Is Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "MiddleName Is Required")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "SurName Is Required")]
        [Display(Name = "Sur Name")]
        public string SurName { get; set; }
        
        [Required(ErrorMessage = "level ID Is Required")]
        [Display(Name = "level")]
        public Nullable<int> LevelID { get; set; }
        [Required(ErrorMessage = "National ID Is Required")]
        [Display(Name = "National Id")]
        public Nullable<decimal> NationalID { get; set; }
        [Required(ErrorMessage = "mobile Is Required")]
        [Display(Name = "mobile")]
        public string Mobile { get; set; }
        [Display(Name = "Student Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "department Is Required")]
        [Display(Name = "department")]
        public Nullable<int> DeptID { get; set; }
        [Required(ErrorMessage = "Gender Is Required")]
        [Display(Name = "Gender")]
        public Nullable<int> GenderID { get; set; }
        [Required(ErrorMessage = "image Is Required")]
        [Display(Name = "image")]
        public string Image { get; set; }
        public Nullable<bool> IsActive { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Students Subjects")]
        public string StudentsSubjects { get; set; }
        [Display(Name = "department")]
        public string depts{get;set;}
        public string levels { get; set; }
        public string genders { get; set; }

    }
}
