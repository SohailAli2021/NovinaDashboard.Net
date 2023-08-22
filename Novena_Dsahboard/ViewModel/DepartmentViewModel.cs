using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.ViewModel
{
    public class DepartmentViewModel
    {
        [Required(ErrorMessage = "Please Add Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Add Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please Add DescriptionB")]
        public string DescriptionB { get; set; }
        [Required(ErrorMessage = "Please Add Image")]

        public IFormFile Image { get; set; }
    }
}
