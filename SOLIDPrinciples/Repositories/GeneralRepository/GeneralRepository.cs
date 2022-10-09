using SOLIDPrinciples.Models;

namespace SOLIDPrinciples.Repositories.GeneralRepository;

public class GeneralRepository<T> : IGeneralRepository<T> where T : BaseEntity
{
    private readonly IList<T> _generalList;
    
    public GeneralRepository(IList<T> generalList)
    {
        _generalList = generalList;
    }
    
    public void Create(T entity)
    {
        _generalList.Add(entity);
    }
    
    public void Update(T entity)
    {
        _generalList.Add(entity);
    }
    
    public void Delete(T entity)
    {
        _generalList.Remove(entity);
    }
}