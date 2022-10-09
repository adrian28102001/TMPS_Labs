using SOLIDPrinciples.Models;
using SOLIDPrinciples.Repositories.GeneralRepository;

namespace SOLIDPrinciples.Repositories.OrderRepository;

//interface segregation
public class OrderRepository : IGeneralRepository<Order>, IOrderRepository
{
    public void Update(Order entity)
    {
        Console.WriteLine("Update entity");
    }

    public void Create(Order entity)
    {
        Console.WriteLine("Create entity");
    }

    public void Delete(Order entity)
    {
        Console.WriteLine("Delete entity");
    }

    public void GenerateOrder()
    {
        Console.WriteLine("Generating an order");
    }
}