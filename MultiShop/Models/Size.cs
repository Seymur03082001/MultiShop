using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Size:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
