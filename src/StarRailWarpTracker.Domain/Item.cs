using StarRailWarpTracker.Domain.Enums.UserSystem;

namespace StarRailWarpTracker.Domain;

public class Item : BaseEntity
{
    public int RollNumber { get; set; }
    public BannerSource Banner { get; set; }
    public int Pity { get; set; }
    public DateTime ObtainDate { get; set; }
    public string Name { get; set; }
    public bool IsGuarantee { get; set; }
    public bool WonRateUp { get; set; }
}
