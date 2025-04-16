using OrderProcessing.Models;

namespace OrderProcessing.Interfaces
{
    public interface IOrderService
    {
        void PlaceOrder(Order order);
    }
}
