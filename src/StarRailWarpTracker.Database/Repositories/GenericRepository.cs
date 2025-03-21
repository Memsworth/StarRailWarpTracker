
using Microsoft.EntityFrameworkCore;
using StarRailWarpTracker.Domain;
using StarRailWarpTracker.Domain.RepositoryContracts;
using System.Linq.Expressions;

namespace StarRailWarpTracker.Database.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private protected readonly DbContext _dbContext;
    public GenericRepository(DbContext dbContext) => _dbContext = dbContext;
    public void Create(T entity)
        => _dbContext.Set<T>().Add(entity);
    public void Delete(T entity)
        => _dbContext.Set<T>().Remove(entity);
    public void Update(T entity)
        => _dbContext.Set<T>().Update(entity);
    public IEnumerable<T> GetAll()
        => _dbContext.Set<T>().AsNoTracking();
    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        => _dbContext.Set<T>().Where(expression).AsNoTracking();
    public T? GetById(int id)
        => _dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
}
