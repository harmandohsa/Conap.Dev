using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public int EmployeetId { get; set; }
        public int PersonaId { get; set; }

        [Required]
        [Display(Name = "Nombre de Usuario")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Clave")]
        public string Password { get; set; }

        public string PasswordChange { get; set; }

        public int UserStatusId { get; set; }


        public virtual Person Person { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual UserStatus UserStatus { get; set; }
    }
}