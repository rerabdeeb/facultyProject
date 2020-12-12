using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
    public class GenderViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Gender Name Is Required")]
        [Display(Name = "Gender")]
        public string Gender1 { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
