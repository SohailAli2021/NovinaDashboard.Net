using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.Models
{
    public class Scientific
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Add Image")]
        public string ProImage { get; set; }

        [Required(ErrorMessage = "Please Add Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Add Price")]
        public string Price { get; set; }
        [Required(ErrorMessage = "Please Add DiscountPrice")]
        public string DiscountPrice { get; set; }
    }
}
