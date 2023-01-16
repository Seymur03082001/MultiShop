using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Setting:BaseEntity
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
