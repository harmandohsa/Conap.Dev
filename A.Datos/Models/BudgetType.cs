using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class BudgetType
    {
        [Key]
        public int BudgetTypeId { get; set; }
        [Required]
        [Display(Name = "Tipo de Contratación")]
        public string BudgetTypeName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}