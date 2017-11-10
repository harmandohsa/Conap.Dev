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

        public int EmployeeId { get; set; }
        //public virtual Employee Employee { get; set; }

        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "Debe ingresar el usuario")]
        public string  UserName { get; set; }

        [Display(Name = "Clave")]
        [Required(ErrorMessage = "Debe ingresar su clave")]
        public string Password { get; set; }
        public int ChangePassword { get; set; }

        public int UserStatusId { get; set; }
        public virtual UserStatus UserStatus { get; set; }

    }
}