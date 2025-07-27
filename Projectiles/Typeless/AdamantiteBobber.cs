using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Projectiles.Typeless;

public class AdamantiteBobber : ModProjectile, ILocalizedModType
{
    public new string LocalizationCategory => "Projectiles.Typeless";

    public override void SetDefaults()
    {
        Projectile.width = 32;
        Projectile.height = 32;
        Projectile.aiStyle = ProjAIStyleID.Bobber;
        Projectile.bobber = true;
    }
}
