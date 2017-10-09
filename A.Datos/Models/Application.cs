using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }
        [Required]
        [DisplayName("Sistema")]
        public string ApplicationName { get; set; }
    }
}