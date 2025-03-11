namespace StarRailWarpTracker.Domain.DatabaseTables.UserDatabase;

public class User : BaseEntity
{
    public int StarRailAccountId { get; set; }
    public string ProfilePhoto { get; set; }
    public ICollection<Character> ObtainedCharacters { get; set; }
    public ICollection<LightCone> ObtainedLightCones { get; set; }
}