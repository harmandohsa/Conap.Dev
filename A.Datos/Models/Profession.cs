using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Profession
    {
        [Key]
        public int ProfessiontId { get; set; }
        [Required]
        [Display(Name = "Profesion")]
        public string ProfessionName { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
    }
}