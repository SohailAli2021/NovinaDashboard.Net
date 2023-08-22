using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.Models
{
    public class Checkout
    {
        [Key]
        public int chkID { get; set; }
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Cardname { get; set; }


        public string Cardnum { get; set; }

        public bool COD { get; set; }


    }
}
