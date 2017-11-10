using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class PermissionUser
    {
        [Key]
        public int PermissionUserId { get; set; }


        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int ProfileId { get; set; }
        public virtual Profile profile { get; set; }

        public int PageId { get; set; }
        public virtual Page Page { get; set; }


        [DisplayName("Acceso")]
        public bool Access { get; set; }

        [DisplayName("Ingresar")]
        public bool Insert { get; set; }

        [DisplayName("Eliminar")]
        public bool Delete { get; set; }

        [DisplayName("Actualizar")]
        public bool Update { get; set; }


    }
}