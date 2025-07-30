using Microsoft.Xna.Framework;

namespace MoreFishingRods.Projectiles.Typeless;

public class SolarBobber : BaseModBobber
{
    public override Vector3? Glow => new Vector3(0f, 0.25f, 0f);
}
