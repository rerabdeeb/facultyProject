using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
    public class LevelsViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Department Name Is Required")]
        [Display(Name = "Level")]

        public string Level { get; set; }
    }
}
