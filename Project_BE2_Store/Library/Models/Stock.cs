using System;
using System.Collections.Generic;

namespace Be2_Store.Models
{
    public partial class Stock
    {
        public string StockId { get; set; } = null!;
        public int? Quanlity { get; set; }
        public int? CurrentQuanlity { get; set; }
        public string? ProductId { get; set; }
        public int? BuyQuanlity { get; set; }

        public virtual Product? Product { get; set; }
    }
}
