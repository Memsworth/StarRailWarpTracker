using Microsoft.EntityFrameworkCore;
using StarRailWarpTracker.Domain.DatabaseTables;

namespace StarRailWarpTracker.Database;

public class ApplicationDbContext : DbContext
{
    public string DbPath { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<LightCone> LightCones { get; set; }

    public ApplicationDbContext()
    {
        var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        DbPath = Path.Join(folderPath, "test.db");
    }
}
