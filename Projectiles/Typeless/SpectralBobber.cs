using Microsoft.Xna.Framework;

namespace MoreFishingRods.Projectiles.Typeless;

public class SpectralBobber : BaseModBobber
{
    public override Vector3? Glow => new Vector3(0.25f, 0.25f, .5f);
}
