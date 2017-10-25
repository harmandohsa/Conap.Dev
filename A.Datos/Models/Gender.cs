using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }
        [Required]
        [Display(Name = "Genero")]
        public string GenderName { get; set; }

        public virtual ICollection<Person> People { get; set; }
        
    }
}