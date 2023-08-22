using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.Models
{
    public class Appointment
    {
        [Key]
        public int ID { get; set; }
        
        public string Department { get; set; }
        
        public string Doctor { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string PhoneNum { get; set; }
        [Required]
        public string YourMassage { get; set; }

    }
}
