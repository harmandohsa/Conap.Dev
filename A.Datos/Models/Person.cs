using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        public string FirstLasName { get; set; }

        public string SecondLasName { get; set; }

        public string MarriegeLasName { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public string ThirdName { get; set; }

        public DateTime BirthDate { get; set; }

        [ForeignKey("MunicipalityBirth"), Column(Order = 0)]
        public int? MunicipalityBirthId { get; set; }
        public virtual Municipality MunicipalityBirth { get; set; }

        public int NumberId { get; set; }
        [ForeignKey("MunicipalityNumber"), Column(Order = 1)]
        public int? MunicipalityNumberId { get; set; }
        public virtual Municipality MunicipalityNumber { get; set; }

        public int GenderId { get; set; }
        public virtual Gender Gender { get; set;}

        public int MaritalStatusId { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }

        public string Address { get; set; }

        [ForeignKey("MunicipalityAddress"), Column(Order = 2)]
        public int? MunicipalityAdreesId { get; set; }
        public virtual Municipality MunicipalityAddress { get; set; }

        public string PassportId { get; set; }
        public string Email { get; set; }
        public string NIT { get; set; }
        public string AfiliationIgss { get; set; }
        public string PhoneNumber { get; set; }
        public string CelularNumber { get; set; }

        public int ProfessiontId { get; set; }
        public virtual Profession Profession { get; set; }

        public string ProfessionalNumber { get; set; }
        public DateTime ProfessionalNumberDate { get; set; }
        public string NumberDriveLicence { get; set; }



        public virtual ICollection<Employee> Employees { get; set; }
    }
}