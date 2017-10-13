using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Headquarter
    {
        [Key]
        public int HeadquarterId { get; set; }
        [Required]
        [Display(Name = "Sede")]
        public string HeadquarterName { get; set; }

    }
}