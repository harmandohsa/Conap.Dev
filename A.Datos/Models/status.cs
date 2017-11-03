using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class status
    {
        [Key]
        public int StatusId { get; set; }
        [Required]
        [Display(Name ="Estado")]
        public string statusName { get; set; }
    }
}