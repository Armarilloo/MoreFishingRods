using Terraria;

namespace MoreFishingRods.Projectiles.Typeless;

public class TitaniumBobber : BaseModBobber
{
    public override bool PreDrawExtras()
    {
        Lighting.AddLight(Projectile.Center, 0f, 0f, 0f);
        return true;
    }
}
