using System;
using System.Collections.Generic;

namespace Be2_Store.Models
{
    public partial class OrderDetail
    {
        public string OrderDetailId { get; set; } = null!;
        public string? OrderId { get; set; }
        public string? ProductId { get; set; }
        public int? Quanlity { get; set; }
        public double? Price { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
