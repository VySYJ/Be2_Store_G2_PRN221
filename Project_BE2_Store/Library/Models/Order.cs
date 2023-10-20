using System;
using System.Collections.Generic;

namespace Be2_Store.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Payments = new HashSet<Payment>();
        }

        public string OrderId { get; set; } = null!;
        public string? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public string? ShipAddress { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public double? Total { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
