using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.ViewModel
{
    public class ScientificViewModel
    {
        [Required(ErrorMessage = "Please Add Image")]
        public IFormFile ProImage { get; set; }

        [Required(ErrorMessage = "Please Add Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Add Price")]
        public string Price { get; set; }
        [Required(ErrorMessage = "Please Add DiscountPrice")]
        public string DiscountPrice { get; set; }
    }
}
