using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.ViewModel
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            
            Roles = new List<string>();
        }
        public string Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
       

        public List<string> Roles { get; set; }
    }
}
