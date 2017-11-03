using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.Datos.Models
{
    public class Ticketcreation
    {
        [Key]
        public int TicketcreationId { get; set; }
        [Required]
        [Display(Name = "Creacion de Ticket" )]
        public string TicketecreationName { get; set; }
    }
}