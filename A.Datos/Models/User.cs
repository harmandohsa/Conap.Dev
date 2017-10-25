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
        public virtual Employee Employee { get; set; }

        public string  UserName { get; set; }
        public string Password { get; set; }
        public int ChangePassword { get; set; }

        public int UserStatusId { get; set; }
        public virtual UserStatus UserStatus { get; set; }

    }
}