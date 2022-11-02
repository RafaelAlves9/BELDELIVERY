namespace BELDELIVERY_API.Models
{
    public class ClientProfile
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int? Orders { get; set; }
        public string? TittleStatus { get; set; }
        public string? Document { get; set; }
        public string? TellPhone { get; set; }
        public string? CellPhone { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
