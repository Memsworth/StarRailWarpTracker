using StarRailWarpTracker.Domain.Enums;

namespace StarRailWarpTracker.Domain.DatabaseTables;

public class LightCone : ItemData
{
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
