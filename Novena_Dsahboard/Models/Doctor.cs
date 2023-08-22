using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Add Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Add Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Add Dep")]
        public string Dep { get; set; }
        [Required(ErrorMessage = "Please Add Picture")]
        public string Picture { get; set; }
        [Required(ErrorMessage = "Please Add Decsription")]
        public string Decsription { get; set; }
    }
}
