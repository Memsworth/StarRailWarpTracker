namespace StarRailWarpTracker.Domain.DatabaseTables;

public class User
{
    public int Id { get; set; }
    public int StarRailAccountId { get; set; }
    public string ProfilePhoto { get; set; }
    public ICollection<Character> ObtainedCharacters { get; set; }
    public ICollection<LightCone> ObtainedLightCones { get; set; }
}
