using Microsoft.Xna.Framework;

namespace MoreFishingRods.Projectiles.Typeless;

public class LuminiteBobber : BaseModBobber
{
    public override Vector3? Glow => new Vector3(0.15f, 1f, 0.68f);
}
