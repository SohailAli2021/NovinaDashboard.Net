using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.Models
{
    public class WebService
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Add Title")]

        public string Heading { get; set; }
        [Required(ErrorMessage = "Please choose add Description")]
        
        public string Description { get; set; }
        [Required(ErrorMessage = "Please choose profile image")]
        public string Picture { get; set; }
    }
}
