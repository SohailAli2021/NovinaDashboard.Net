using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.Models
{
    public class Casestudy
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Add Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Add Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please chose Image")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Please chose Date")]
        public DateTime Date { get; set; }
    }
}
