using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Municipality
    {
        [Key]
        public int MunicipalityId { get; set; }
        [Required]
        [Display(Name = "Municipio")]
        public string MunicipalityName { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
    }
}