using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Employee
    {
        [Key]
        public int EmployeetId { get; set; }
        public int PersonaId { get; set; }


        public virtual Person Person { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}