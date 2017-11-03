using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Priority
    {
        [Key]

        public int PriorityId { get; set; }
        [Required]
        [Display(Name = "Prioridad")]
        public string PriorityName { get; set; }
    }
}