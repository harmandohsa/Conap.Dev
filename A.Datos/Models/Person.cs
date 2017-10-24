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
        [Display (Name ="Primer Nombre")]
        public string FirstName { get; set; }
        [Display(Name = "Segundo Nombre")]
        public string SecondName { get; set; }
        [Display(Name = "Tercer Nombre")]
        public string ThirdName { get; set; }
        [Required]
        [Display(Name = "Primer Apellido")]
        public string FirstLastName { get; set; }
        [Display(Name = "Segundo Apellido")]
        public string SecondLastName { get; set; }
        [Display(Name = "Apellido de Casada")]
        public string MarriegeLastName { get; set; }
        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime BirthData { get; set; }
        [Required]
        [Display(Name = "Departamento de Nacimiento")]
        public int DepartmentId { get; set; }

        [Required]
        [Display(Name = "Municipio de Nacimiento")]
        public int MunicipalityId { get; set; }
        [Required]
        [Display(Name = "DPI")]
        public int NumberId { get; set; }
        [Display(Name = "Departamento de extensión DPI")]
        public int DepartmentDpiId { get; set; }

        [Display(Name = "Municipio  de extensión DPI")]
        public int MunicipalityDpiId { get; set; }
        [Display(Name = "Pasaporte")]
        public string PassportId { get; set; }

        [Display(Name = "País")]
        public int CountrytId { get; set; }
        [Required(ErrorMessage = "El campo Genero es obligatorio")]
        [Display(Name = "Genero")]
        public int GenderId { get; set; }

        [Required(ErrorMessage = "El campo Estado civil es obligatorio")]
        [Display(Name = "Estado Civil")]
        public int MaritalStatusId { get; set; }
        [Required]
        [Display(Name = "Dirección")]
        public string Adrress { get; set; }
        [Required]
        [Display(Name = "Correo Eléctronico")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "NIT")]
        public string NIT { get; set; }

        [Required]
        [Display(Name = "No. de Afiliación IGSS")]
        public string IGSSMembership { get; set; }


        [Required]
        [Display(Name = "Teléfono de Residencia")]
        public string House_Phone { get; set; }

        [Required]
        [Display(Name = "Teléfono Celular")]
        public string Celular_Phone { get; set; }

        public int ProfessiontId { get; set; }

        [Display(Name = "No. de colegiado activo")]
        public int CollegiateId { get; set; }

        [Display(Name = "Fecha de Colegiación")]
        public DateTime CollegiateDate { get; set; }

        [Display(Name = "No. de licencia de conducir y clase")]
        public int DriverLicenceId { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual Department Department { get; set; }
        public virtual Municipality Municipalities { get; set; }
        public virtual Country Countries { get; set; }
        public virtual MaritalStatus MaritalStatues { get; set;}
        public virtual Profession Professions { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }

        public virtual ICollection<User> Users { get; set; }
     }
}