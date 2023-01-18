using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class ProductImage:BaseEntity
    {
        public string ImgUrl { get; set; }
        public bool IsPrimary { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
