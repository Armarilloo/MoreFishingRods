using Terraria;

namespace MoreFishingRods.Projectiles.Typeless;

public class ChlorophyteBobber : BaseModBobber
{
    public override bool PreDrawExtras()
    {
        Lighting.AddLight(Projectile.Center, 0f, 0.25f, 0f);
        return true;
    }
}
