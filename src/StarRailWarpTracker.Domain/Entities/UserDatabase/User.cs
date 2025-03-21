using StarRailWarpTracker.Domain.DatabaseTables.UserDatabase;

namespace StarRailWarpTracker.Domain.Entities.UserDatabase;

public class User : BaseEntity
{
    public int StarRailAccountId { get; set; }
    public string ProfilePhoto { get; set; }
    public ICollection<Character> ObtainedCharacters { get; set; }
    public ICollection<Lightcone> ObtainedLightCones { get; set; }
}