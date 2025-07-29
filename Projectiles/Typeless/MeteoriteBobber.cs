using Microsoft.Xna.Framework;

namespace MoreFishingRods.Projectiles.Typeless;

public class MeteoriteBobber : BaseModBobber
{
    public override Vector3? Glow => new Vector3(.25f, 0.15f, 0f);
}
