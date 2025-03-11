using Microsoft.EntityFrameworkCore;
using StarRailWarpTracker.Domain.DatabaseTables;
using StarRailWarpTracker.Domain.DatabaseTables.UserDatabase;

namespace StarRailWarpTracker.Database;

public class UserDbContext : DbContext
{
    private string DbPath { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<LightCone> LightCones { get; set; }

    public UserDbContext()
    {
        var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        DbPath = Path.Join(folderPath, "test.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
