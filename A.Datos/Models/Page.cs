using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Page
    {
        [Key]
        public int PageId { get; set; }
        [Required]
        [Display(Name = "Página")]
        public string PageName { get; set; }
        public int ApplicationId { get; set; }
        public virtual Application Application { get; set; }

        public virtual ICollection<PermissionProfile> PermissionsProfiles { get; set; }

        public virtual ICollection<PermissionUser> PermissionsUsers { get; set; }

    }
}