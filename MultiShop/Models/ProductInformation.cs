using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class ProductInformation:BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
