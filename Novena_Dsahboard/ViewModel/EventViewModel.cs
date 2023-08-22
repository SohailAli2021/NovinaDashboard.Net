using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.ViewModel
{
    public class EventViewModel
    {
        
        public string Heading { get; set; }
       
        public string Text { get; set; }
        
        public IFormFile Image { get; set; }
        [Required(ErrorMessage = "Please Add Date")]
        public string Date { get; set; }
        [Required(ErrorMessage = "Please Add Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Add Description")]
        public string Decsription { get; set; }
    }
}
