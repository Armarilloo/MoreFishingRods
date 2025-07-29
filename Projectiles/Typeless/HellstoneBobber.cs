using Microsoft.Xna.Framework;

namespace MoreFishingRods.Projectiles.Typeless;

public class HellstoneBobber : BaseModBobber
{
    public override Vector3? Glow => new Vector3(.25f, 0.10f, 0.2f);
}
