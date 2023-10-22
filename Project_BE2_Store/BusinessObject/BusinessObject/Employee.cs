using System;
using System.Collections.Generic;

namespace BusinessObject.BusinessObject
{
    public partial class Employee
    {
        public Employee()
        {
            Payments = new HashSet<Payment>();
        }

        public string EmployeeId { get; set; } = null!;
        public string? EmployeeName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
