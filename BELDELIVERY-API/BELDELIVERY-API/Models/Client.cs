namespace BELDELIVERY_API.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Document { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TypeAccountAcess { get; set; }
        //public virtual StoreProfile StoreProfile { get; set; }
        //public virtual List<StoreAddress> StoreAddress { get; set; }
        //public virtual List<Product> Product { get; set; }
    }
}
