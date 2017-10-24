using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Datos.Models
{
    public class Country
    {
        [Key]
        public int CountrytId { get; set; }
        [Required]
        [Display(Name = "País")]
        public string CountryName { get; set; }

    }
}
