using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods
{
    public class AdamantiteFishingRod : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Fishing";

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 48;
            Item.useAnimation = 8;
            Item.useTime = 8;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;
            Item.fishingPole = 35;
            Item.shootSpeed = 14.5f;
            Item.shoot = ModContent.ProjectileType<AdamantiteBobber>();
            Item.value = Item.buyPrice(gold: 2);
            Item.rare = ItemRarityID.LightRed;
        }

        public override void ModifyFishingLine(
            Projectile bobber,
            ref Vector2 lineOriginOffset,
            ref Color lineColor
        )
        {
            lineOriginOffset = new Vector2(47f, -33f);
            lineColor = new Color(208, 208, 208);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.AdamantiteBar, 6)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}
