using System;
using System.Collections.Generic;

namespace BusinessObject.BusinessObject
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Stocks = new HashSet<Stock>();
        }

        public string ProductId { get; set; } = null!;
        public string? ProductName { get; set; }
        public double? Price { get; set; }
        public string? Image { get; set; }
        public string? Desciption { get; set; }
        public string? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
