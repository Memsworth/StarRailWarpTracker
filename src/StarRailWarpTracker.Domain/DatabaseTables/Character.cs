namespace StarRailWarpTracker.Domain.DatabaseTables;

public class Character : ItemData
{
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
