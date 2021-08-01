using System.ComponentModel.DataAnnotations;

namespace Product_Kolmeo.Entities
{
    public class Product
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
