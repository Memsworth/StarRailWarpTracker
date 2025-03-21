namespace StarRailWarpTracker.Domain.Entities.UserDatabase;

public class Lightcone : Item
{
    public int LightconeId { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
