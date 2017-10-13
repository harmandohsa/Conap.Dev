using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Dependence
    {
        [Key]
        public int DependenceId { get; set; }
        [Required]
        [Display(Name = "Dirección")]
        public string DependeceName { get; set; }

        public virtual ICollection<Area> Areas { get; set; }

    }
}