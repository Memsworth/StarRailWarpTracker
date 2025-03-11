namespace StarRailWarpTracker.Domain.DatabaseTables.UserDatabase;

public class LightCone : ItemData
{
    public int UniqueLightconeId { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
