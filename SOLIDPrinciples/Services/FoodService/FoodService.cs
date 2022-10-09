using SOLIDPrinciples.Repositories.FoodRepository;

namespace SOLIDPrinciples.Services.FoodService;

public class FoodService : IFoodService
{
    //Dependency inversion
    private readonly IFoodRepository _foodRepository;

    public FoodService(IFoodRepository foodRepository)
    {
        _foodRepository = foodRepository;
    }

    public void GenerateFood()
    {
        _foodRepository.GenerateFood();
    }
}