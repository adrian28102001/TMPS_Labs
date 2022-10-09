using SOLIDPrinciples.Models;
using SOLIDPrinciples.Repositories.GeneralRepository;

namespace SOLIDPrinciples.Repositories.FoodRepository;

//interface segregation
public class FoodRepository : IGeneralRepository<Food>
{
    public void Update(Food entity)
    {
        Console.WriteLine("Update entity");
    }

    public void Create(Food entity)
    {
        Console.WriteLine("Create entity");
    }

    public void Delete(Food entity)
    {
        Console.WriteLine("Delete entity");
    }
}
