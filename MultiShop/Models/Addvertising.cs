﻿using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Addvertising:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }
}
