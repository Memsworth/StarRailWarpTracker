using Microsoft.EntityFrameworkCore;
using StarRailWarpTracker.Domain.Entities.UserDatabase;

namespace StarRailWarpTracker.Database;

public class UserDbContext : BaseDbContext
{
    private string DbPath { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Lightcone> LightCones { get; set; }


    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
        var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        DbPath = Path.Join(folderPath, "test.db");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
