namespace BELDELIVERY_API.Models
{
    public class Administrator
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TypeAccount { get; set; }
    }
}
