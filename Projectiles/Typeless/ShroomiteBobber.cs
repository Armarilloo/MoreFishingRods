using Terraria;

namespace MoreFishingRods.Projectiles.Typeless;

public class ShroomiteBobber : BaseModBobber
{
    public override bool PreDrawExtras()
    {
        Lighting.AddLight(Projectile.Center, 0f, 0f, .5f);
        return true;
    }
}
