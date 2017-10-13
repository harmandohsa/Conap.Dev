using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Datos.Models
{
    public class Area
    {
        [Key]
        public int AreaId { get; set; }
        [Required]
        [Display (Name = "Departamento")]
        public string AreaName { get; set; }

        public int DependenceId { get; set; }

        public virtual Dependence Dependence { get; set; }
    }
}
