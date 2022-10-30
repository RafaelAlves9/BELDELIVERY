namespace BELDELIVERY_API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int IdStore { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Quantity { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string Ingredients { get; set; }
        public string TypeProduct { get; set; }
    }
}
