using A.Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace A.Datos.Context
{
    public class ConapContext : DbContext
    {
        
        public DbSet<Application> Applications { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.Page> Pages { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.User_Type> User_Type { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.Gender> Genders { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.Dependence> Dependences { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.Area> Areas { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.Position> Positions { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.Headquarter> Headquarters { get; set; }


        public System.Data.Entity.DbSet<A.Datos.Models.Country> Countries { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.Municipality> Municipalities { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.MaritalStatus> MaritalStatus { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.Profession> Professions { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.UserStatus> UserStatus { get; set; }

        public System.Data.Entity.DbSet<A.Datos.Models.Profile> Profiles { get; set; }
    }
}