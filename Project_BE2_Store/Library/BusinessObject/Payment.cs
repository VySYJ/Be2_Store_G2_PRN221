using System;
using System.Collections.Generic;

namespace BusinessObject.BusinessObject
{
    public partial class Payment
    {
        public string PaymentId { get; set; } = null!;
        public string? OrderId { get; set; }
        public string? PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string? EmployeeId { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual Order? Order { get; set; }
    }
}
