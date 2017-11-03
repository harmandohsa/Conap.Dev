using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Type_Support

    {
        [Key]
        public int TypesupportId { get; set; }
        [Required]
        [Display(Name = "Tipo de Soporte")]
        public string TypesupportName { get; set; }
    }
}