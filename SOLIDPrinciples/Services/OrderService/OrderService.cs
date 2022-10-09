using SOLIDPrinciples.Repositories.OrderRepository;

namespace SOLIDPrinciples.Services.OrderService;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public void GenerateOrder()
    {
        _orderRepository.GenerateOrder();
    }
}