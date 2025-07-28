using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Projectiles.Typeless;

public abstract class BaseModBobber : ModProjectile
{
    public virtual int Width => 14;
    public virtual int Height => 20;

    public virtual Vector3? Glow => null;

    public override void SetDefaults()
    {
        Projectile.width = Width;
        Projectile.height = Height;
        Projectile.aiStyle = ProjAIStyleID.Bobber;
        Projectile.bobber = true;
    }

    public override bool PreDrawExtras()
    {
        if (Glow != null)
            Lighting.AddLight(Projectile.Center, Glow.Value);
        return true;
    }
}
