using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
    }
}