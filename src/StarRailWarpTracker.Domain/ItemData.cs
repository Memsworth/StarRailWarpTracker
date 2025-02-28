using StarRailWarpTracker.Domain.Enums;

namespace StarRailWarpTracker.Domain;

public class ItemData
{
    public int Id { get; set; }
    public int RollNumber { get; set; }
    public BannerSource Source { get; set; }
    public int Pity { get; set; }
    public DateTime ObtainDate { get; set; }
    public string ItemName { get; set; }
    public bool IsGuarantee { get; set; }
    public bool WonRateUp { get; set; }
    public ItemRarity Rarity { get; set; }
}
