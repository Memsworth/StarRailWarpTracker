using StarRailWarpTracker.Domain.Enums.GameSystem;

namespace StarRailWarpTracker.Domain.DatabaseTables.GameDatabase;

public class UniqueLightcone : BaseEntity
{
    public PathSystem Path { get; set; }
    public RaritySystem Rarity { get; set; }
    public required string StaticFile { get; set; }
    public required string Name { get; set; }
}