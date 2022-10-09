namespace SOLIDPrinciples.Repositories.GeneralRepository;

public interface IGeneralRepository<in T>
{
    //interface segregation
    void Update(T entity);
    void Create(T entity);
    void Delete(T entity);
}