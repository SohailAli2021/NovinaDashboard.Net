using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.Models
{
    public class Feedback
    {
        
        
            [Key]
            public int ID { get; set; }

            public string FullName { get; set; }

            public string EmailAddress { get; set; }

            public string PhoneNum { get; set; }

            public string YourMassage { get; set; }
        
    }
}
