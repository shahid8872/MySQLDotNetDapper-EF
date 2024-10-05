namespace DadCommerce.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public string? Address { get; set; }
        public string? EmailAddress { get; set; }
        public string? AddressCity { get; set; }
    }
}
