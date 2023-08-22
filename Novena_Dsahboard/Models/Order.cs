using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.Models
{
    public class Order
    {
        [Key]
        public int o_id { get; set; }

        public Nullable<System.DateTime> o_date { get; set; }
        public Nullable<int> o_qty { get; set; }
        public Nullable<double> o_bill { get; set; }
        public Nullable<int> o_unitprice { get; set; }
        public Nullable<int> o_fk_pro { get; set; }
        public virtual  Product Product { get; set; }
        public Nullable<int> o_fk_invoice { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
