using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class UserStatus
    {
        [Key]
        public int UserStatusId { get; set; }
        [Required]
        [Display(Name = "Estatus Usuario")]
        public string UserStatusName { get; set; }

    }
}