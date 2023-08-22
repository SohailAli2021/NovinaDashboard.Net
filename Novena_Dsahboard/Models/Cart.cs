using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.Models
{
    [NotMapped]
    public class Cart
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        //public int productid { get; set; }
        //public string Productname { get; set; }
        //public float price { get; set; }
        public int qty { get; set; }
        //public float bill { get; set; }
    }
}
