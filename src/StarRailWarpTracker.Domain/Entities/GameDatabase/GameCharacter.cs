using StarRailWarpTracker.Domain.Enums.GameEnums;

namespace StarRailWarpTracker.Domain.Entities.GameDatabase;

public class GameCharacter : BaseEntity
{
    public ElementalSystem Element { get; set; }
    public PathSystem Path { get; set; }
    public RaritySystem Rarity { get; set; }
    public required string StaticFile { get; set; }
    public required string Name { get; set; }
}