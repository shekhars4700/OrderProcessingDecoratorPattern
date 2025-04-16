using OrderProcessing.Interfaces;
using OrderProcessing.Models;

namespace OrderProcessing.Services
{
    public class ValidationDecorator : IOrderService
    {
        private readonly IOrderService _inner;

        public ValidationDecorator(IOrderService inner)
        {
            _inner = inner;
        }

        public void PlaceOrder(Order order)
        {
            Console.WriteLine($"[INFO] Validation Started for the order {order.ProductName}...");
            if (string.IsNullOrEmpty(order.ProductName))
                throw new ArgumentException("Product name is required.");

            if (order.Quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            Console.WriteLine("[INFO] Order is valid.");
            _inner.PlaceOrder(order);
        }
    }
}
