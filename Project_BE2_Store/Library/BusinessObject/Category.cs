﻿using System;
using System.Collections.Generic;

namespace BusinessObject.BusinessObject
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string CategoryId { get; set; } = null!;
        public string? CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
