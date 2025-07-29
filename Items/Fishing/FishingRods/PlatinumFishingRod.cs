using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class PlatinumFishingRod : BaseModFishingRod
{
    public override int FishingPower => 17;
    public override int BobberProjectile => ModContent.ProjectileType<PlatinumBobber>();
    public override int Value => Item.sellPrice(silver: 75);
    public override int Rarity => ItemRarityID.White;
    public override int CraftingIngredient => ItemID.PlatinumBar;
    public override int CraftingTile => TileID.Anvils;
    public override Color LineColor => new Color(246, 216, 235, 1);
}
