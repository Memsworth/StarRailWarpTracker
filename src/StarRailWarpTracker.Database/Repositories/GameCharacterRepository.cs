using StarRailWarpTracker.Domain.Entities.GameDatabase;
using StarRailWarpTracker.Domain.RepositoryContracts;

namespace StarRailWarpTracker.Database.Repositories;

public class GameCharacterRepository : GenericRepository<GameCharacter>, IGameCharacterRepository   
{
    private protected readonly GameDbContext _dbContext;
    public GameCharacterRepository(GameDbContext dbContext) : base(dbContext) 
    {
        _dbContext = dbContext;
    }

    public void tell()
    {
    }
}