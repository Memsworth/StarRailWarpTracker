using Microsoft.EntityFrameworkCore;
using StarRailWarpTracker.Domain.Entities.GameDatabase;

namespace StarRailWarpTracker.Database;

public class GameDbContext : BaseDbContext
{
    private string DbPath { get; set; }
    public DbSet<GameCharacter> GameCharacters { get; set; }
    public DbSet<GameLightcone> GameLightcones { get; set; }

    public GameDbContext(DbContextOptions<GameDbContext> options) : base(options)
    {
        var folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        DbPath = Path.Combine(folder, "StarRailWarpTracker.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}