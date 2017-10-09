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
    }
}