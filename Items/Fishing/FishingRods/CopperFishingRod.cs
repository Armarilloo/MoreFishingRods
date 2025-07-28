using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class CopperFishingRod : BaseModFishingRod
{
    public override int FishingPower => 10;
    public override int BobberProjectile => ModContent.ProjectileType<CopperBobber>();
    public override int Value => Item.sellPrice(silver: 35);
    public override int Rarity => ItemRarityID.White;
    public override int CraftingIngredient => ItemID.CopperBar;
    public override int CraftingTile => TileID.Anvils;
    public override Color LineColor => new Color(255, 226, 217, 1);
}
