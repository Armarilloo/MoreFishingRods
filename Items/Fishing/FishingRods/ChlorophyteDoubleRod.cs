using MoreFishingRods.Projectiles.Typeless;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods
{
    public class ChlorophyteDoubleRod : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Fishing.FishingRods";
        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 48;
            Item.useAnimation = 8;
            Item.useTime = 8;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;
            Item.fishingPole = 40;
            Item.shootSpeed = 16f;
            Item.shoot = ModContent.ProjectileType<ChlorophyteBobber>();
            Item.value = 37500;
            Item.rare = ItemRarityID.Lime;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            for (int i = 0; i < 2; i++)
            {
                Projectile.NewProjectile(source, position, velocity.RotatedByRandom(MathHelper.ToRadians(18f)), type, 0, 0f, player.whoAmI);
            }
            return false;
        }

        public override void ModifyFishingLine(Projectile bobber, ref Vector2 lineOriginOffset, ref Color lineColor)
        {
            lineOriginOffset = new Vector2(47f, -33f);
            lineColor = new Color(234, 254, 126, 1);
        }

        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.ChlorophyteBar, 6).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}