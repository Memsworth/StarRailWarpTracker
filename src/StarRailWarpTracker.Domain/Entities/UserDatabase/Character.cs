namespace StarRailWarpTracker.Domain.Entities.UserDatabase;

public class Character : Item
{
    public int CharacterId { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
