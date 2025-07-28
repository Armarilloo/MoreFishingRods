using Terraria;

namespace MoreFishingRods.Projectiles.Typeless;

public class SpectralBobber : BaseModBobber
{
    public override bool PreDrawExtras()
    {
        Lighting.AddLight(Projectile.Center, 0.25f, 0.25f, .5f);
        return true;
    }
}
