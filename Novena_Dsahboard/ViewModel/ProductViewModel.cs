using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novena_Dsahboard.ViewModel
{
    public class ProductViewModel
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public IFormFile ProImage { get; set; }
        public string Description { get; set; }
        public string Catagory { get; set; }
    }
}

//public enum Cata
//{
//    //[Display(Name = "Child Care")]
//    ChlidCare = 10,

//    Diabetes = 11,
//    //[Display(Name ="Adult Health")]
//    AdultHealth = 12,
//    //[Display(Name = "Immume Medicine")]
//    ImmumeMedicine = 13,
//    //[Display(Name = "Pain Killers")]
//    PainKillers = 14,

//    Antibiotics = 15,
//}


