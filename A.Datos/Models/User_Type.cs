using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class User_Type
    {
        [Key]
        public int User_TypeId { get; set; }
        [Required]
        [Display(Name = "Tipo de Usuario")]
        public string User_TypeName { get; set; }

        public int ApplicationId { get; set; }

        public virtual Application Application { get; set; }
    }
}