using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Novena_Dsahboard.Models
{
    public class Invoice
    {
        [Key]
        public int in_id { get; set; }

        public Nullable<System.DateTime> in_date { get; set; }
        public Nullable<double> in_totalbill { get; set; }
        public Nullable<int> in_fk_user { get; set; }
        public virtual IdentityUser User { get; set; }

    }
}
