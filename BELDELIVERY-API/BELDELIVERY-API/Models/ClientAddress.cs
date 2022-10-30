namespace BELDELIVERY_API.Models
{
    public class ClientAddress
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public string Cep { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Distrity { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public bool MainAddress { get; set; }
    }
}
