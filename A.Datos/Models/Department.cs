using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [Display(Name = "Departamento")]
        public string DepartamentName { get; set; }

        public virtual ICollection<Municipality> Municipalities { get; set; }

        

    }
}