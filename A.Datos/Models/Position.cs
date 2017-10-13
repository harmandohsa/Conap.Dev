using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        [Required]
        [Display(Name = "Puesto")]
        public string PositionName { get; set; }
    }
}