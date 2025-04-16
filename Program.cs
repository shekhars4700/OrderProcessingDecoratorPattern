using Microsoft.Extensions.DependencyInjection;
using OrderProcessing.Interfaces;
using OrderProcessing.Models;
using OrderProcessing.Services;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();

        services.AddTransient<OrderService>();

        // Manual decorator chaining
        services.AddTransient<IOrderService>(sp =>
        {
            // Core
            var core = sp.GetRequiredService<OrderService>();

            // Decorator chain
            IOrderService service = core;
            service = new ValidationDecorator(service);
            
            return service;
        });

        var provider = services.BuildServiceProvider();
        var orderService = provider.GetRequiredService<IOrderService>();

        // Sample order

        var order = new Order { ProductName = "Laptop", Quantity = 1, CustomerId = "CUST123" };
        orderService.PlaceOrder(order);
    }
}
