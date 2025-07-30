using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Projectiles.Typeless;

public class TestBobber1 : BaseModBobber
{
    public override Vector3? Glow => new Vector3(1f, 1f, 1f);

    public override void SetDefaults()
    {
        base.SetDefaults();
        Projectile.aiStyle = ProjAIStyleID.Zenith;
    }

    public override bool? CanDamage() => true;

    public override void AI()
    {
        Projectile.damage = 200;
        base.AI();
    }
}
