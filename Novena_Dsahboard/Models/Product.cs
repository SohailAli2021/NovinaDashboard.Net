using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public string ProImage { get; set; }
        public string Description { get; set; }
        public string Catagory { get; set; }
    }
}


