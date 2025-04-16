using OrderProcessing.Interfaces;
using OrderProcessing.Models;

namespace OrderProcessing.Services
{
    public class OrderService : IOrderService
    {
        public void PlaceOrder(Order order)
        {
            Console.WriteLine($"[INFO] Order placed for {order.ProductName} (Qty: {order.Quantity})");
        }

    }
}
