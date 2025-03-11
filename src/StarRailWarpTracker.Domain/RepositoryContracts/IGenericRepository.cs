using System.Linq.Expressions;

namespace StarRailWarpTracker.Domain.RepositoryContracts;

public interface IGenericRepository<T> where T : BaseEntity
{
    T? GetById(int id);
    IEnumerable<T> GetAll();
    IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    void Add(T entity);
    void Remove(T entity);
}
