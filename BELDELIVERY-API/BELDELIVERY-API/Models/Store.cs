namespace BELDELIVERY_API.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Email { get; set; }
        public string Password { get; set; }
        public string Document { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TypeAccountAcess { get; set; }
        public string TypeStore { get; set; }
        public string UrlName { get; set; }
    }
}
