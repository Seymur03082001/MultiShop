using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Discount:BaseEntity
    {
        public string Name { get; set; }
        public double Percentage { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
