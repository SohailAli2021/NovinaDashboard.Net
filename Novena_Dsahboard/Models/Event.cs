using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        
        public string Heading { get; set; }
       
        public string Text { get; set; }
       
        public string Image { get; set; }
        [Required(ErrorMessage = "Please Add Date")]
        public string Date { get; set; }
        [Required(ErrorMessage = "Please Add Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Add Description")]
        public string Decsription { get; set; }


    }
}
