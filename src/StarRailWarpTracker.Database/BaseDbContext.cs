using Microsoft.EntityFrameworkCore;

namespace StarRailWarpTracker.Database;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions options) : base(options) { }
}
