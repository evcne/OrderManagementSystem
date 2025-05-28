namespace Order.API.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string Product { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
