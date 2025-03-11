namespace StarRailWarpTracker.Domain.DatabaseTables.UserDatabase;

public class Character : ItemData
{
    public int UniqueCharacterId { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
