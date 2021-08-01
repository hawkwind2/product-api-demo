namespace Product_Kolmeo.Models
{
    //note: this view model is used both for adding and getting products, in real scenario we would create a different vm for adding
    public class ProductModel
    {
        public long Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}
