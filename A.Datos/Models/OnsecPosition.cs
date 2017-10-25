using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class OnsecPosition
    {
        [Key]
        public int OnsecPositionId { get; set; }
        [Required]
        [Display(Name = "Puesto Onsec")]
        public string OnsecPositionName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}