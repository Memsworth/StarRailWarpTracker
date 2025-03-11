using Microsoft.EntityFrameworkCore;
using StarRailWarpTracker.Domain.DatabaseTables.GameDatabase;

namespace StarRailWarpTracker.Database;

public class GameDbContext : DbContext
{
    private string DbPath { get; set; }
    public DbSet<UniqueCharacter> UniqueCharacters { get; set; }
    public DbSet<UniqueLightcone> UniqueLightcones { get; set; }
    public GameDbContext()
    {
        var folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        DbPath = Path.Combine(folder, "StarRailWarpTracker.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
