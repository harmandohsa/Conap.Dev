using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Datos.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        public int HeadquarterId { get; set; }
        public virtual Headquarter Headquarter { get; set; }

        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        public int OnsecPositionId { get; set; }
        public virtual OnsecPosition OnsecPosition { get; set; }

        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }

        public string BudgetRow { get; set; }
        public int BudgetTypeId { get; set; }
        public virtual BudgetType BudgetType { get; set; }

        public int AreaId { get; set; }
        public virtual Area Area { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
