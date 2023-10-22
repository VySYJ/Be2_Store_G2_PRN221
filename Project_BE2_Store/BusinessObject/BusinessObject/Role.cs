using System;
using System.Collections.Generic;

namespace BusinessObject.BusinessObject
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
            Employees = new HashSet<Employee>();
        }

        public int RoleId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
