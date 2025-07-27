using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Projectiles.Typeless;

public class BaseModBobber : ModProjectile
{
    public virtual int Width => 14;
    public virtual int Height => 20;

    public override void SetDefaults()
    {
        Projectile.width = Width;
        Projectile.height = Height;
        Projectile.aiStyle = ProjAIStyleID.Bobber;
        Projectile.bobber = true;
    }
}
