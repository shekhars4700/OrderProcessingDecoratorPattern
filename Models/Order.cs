namespace OrderProcessing.Models
{
    public class Order
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string CustomerId { get; set; }
    }
}
