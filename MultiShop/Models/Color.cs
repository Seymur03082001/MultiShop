﻿using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Color:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ProductColor>? ProductColors { get; set; }
    }
}
