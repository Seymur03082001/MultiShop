using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Category:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Image { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
