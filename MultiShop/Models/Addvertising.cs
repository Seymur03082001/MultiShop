using MultiShop.Models.Base;

namespace MultiShop.Models
{
    public class Addvertising:BaseEntity
    {
        public string PrimaryTitle { get; set; }
        public string SecondaryTitle { get; set; }
        public string ImageUrl { get; set; }
        public string BtnName { get; set;}
    }
}
