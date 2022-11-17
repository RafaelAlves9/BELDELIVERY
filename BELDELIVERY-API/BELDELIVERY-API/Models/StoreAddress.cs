namespace BELDELIVERY_API.Models
{
    public class StoreAddress
    {
        public int Id { get; set; }
        public int IdStore { get; set; }
        public string Cep { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Distrity { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

    }
}
