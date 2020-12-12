using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
    public class ProfessorViewModel
    {
        public int ID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        [Display(Name = "Name")]

        public string Name { get; set; }
        [Required(ErrorMessage = "image  Is Required")]
        [Display(Name = "image")]

        public string image { get; set; }
    }
}
