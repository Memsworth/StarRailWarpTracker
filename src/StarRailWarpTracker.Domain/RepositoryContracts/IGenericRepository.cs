using System.Linq.Expressions;

namespace StarRailWarpTracker.Domain.RepositoryContracts;

public interface IGenericRepository<T> where T : BaseEntity
{
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    IEnumerable<T> GetAll();
    T? GetById(int id);
    IEnumerable<T> Find(Expression<Func<T, bool>> expression);

}
