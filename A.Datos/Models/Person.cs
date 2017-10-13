using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Person
    {
        [Key]
        public int PersonaId { get; set; }
        [Required]
        [Display (Name ="Nombres")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Correo Eléctronico")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Teléfono")]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "DPI")]
        public int NumberId { get; set; }
        [Display(Name = "Pasaporte")]
        public string PassportId { get; set; }
        public int GenderId { get; set; }


        [Required]
        [Display(Name="Fecha de Nacimiento")]
        public DateTime BirthData { get; set; }
        public virtual Gender Gender { get; set; }
    }
}