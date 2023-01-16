using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Product:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public ICollection<Size> Sizes { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
