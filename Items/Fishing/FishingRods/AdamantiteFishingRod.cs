using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods
{
    public class AdamantiteFishingRod : BaseModFishingRod
    {
        public override int FishingPower => 35;
        public override int BobberProjectile => ModContent.ProjectileType<AdamantiteBobber>();
        public override int Value => Item.buyPrice(gold: 2);
        public override int Rarity => ItemRarityID.LightRed;
        public override int CraftingIngredient => ItemID.AdamantiteBar;
        public override int CraftingTile => TileID.MythrilAnvil;
    }
}
