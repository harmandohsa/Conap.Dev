using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }

        [Required]
        [Display(Name = "Perfil")]
        public string ProfileName { get; set; }

        public int ApplicationId { get; set; }

        public virtual Application Applications { get; set; }
    }
}