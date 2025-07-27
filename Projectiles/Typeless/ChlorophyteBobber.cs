using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace MoreFishingRods.Projectiles.Typeless
{
    public class ChlorophyteBobber : ModProjectile, ILocalizedModType
    {
        public new string LocalizationCategory => "Projectiles.Typeless";
        public override void SetDefaults()
        {
            Projectile.width = 14;
            Projectile.height = 20;
            Projectile.aiStyle = ProjAIStyleID.Bobber;
            Projectile.bobber = true;
        }

        public override bool PreDrawExtras()
        {
            Lighting.AddLight(Projectile.Center, 0f, 0.25f, 0f);
            return true;
        }
    }
}