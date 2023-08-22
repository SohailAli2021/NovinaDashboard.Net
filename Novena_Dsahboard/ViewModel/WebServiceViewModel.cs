using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.ViewModel
{
    public class WebServiceViewModel
    {
        public string Heading { get; set; }
        [Required(ErrorMessage = "Please choose add Description")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Please choose profile image")]
        

        public IFormFile Picture { get; set; }
    }
}
