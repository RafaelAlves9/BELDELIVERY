namespace BELDELIVERY_API.Models
{
    public class StoreProfile
    {
        public int Id { get; set; }
        public int IdStore { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public string TittleStatus { get; set; }
        public string Orders { get; set; }
        public string TellPhone { get; set; }
        public string CellPhone { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
