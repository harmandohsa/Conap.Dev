using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Municipality
    {
        [Key]
        public int MunicipalityId { get; set; }
        [Required]
        [Display(Name = "Municipio")]
        public string MunicipalityName { get; set; }

        public int DepartmentId { get; set; }

        public int NumberId { get; set; }


        public virtual Department Department { get; set; }


        [InverseProperty("MunicipalityBirth")]
        public virtual ICollection<Person> BirthPeople { get; set; }

        [InverseProperty("MunicipalityNumber")]
        public virtual ICollection<Person> NumberPeople { get; set; }

        [InverseProperty("MunicipalityAddress")]
        public virtual ICollection<Person> AddressPeople { get; set; }

    }
}