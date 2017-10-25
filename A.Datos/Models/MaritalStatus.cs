using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class MaritalStatus
    {
        [Key]
        public int MaritalStatusId { get; set; }
        [Required]
        [Display(Name = "Estado Civil")]
        public string MaritalStatustName { get; set; }

        public virtual ICollection<Person> People { get; set; }
       
    }
}