using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class TinFishingRod : BaseModFishingRod
{
    public override int FishingPower => 10;
    public override int BobberProjectile => ModContent.ProjectileType<TinBobber>();
    public override int Value => Item.sellPrice(silver: 25);
    public override int Rarity => ItemRarityID.White;
    public override int CraftingIngredient => ItemID.TinBar;
    public override int CraftingTile => TileID.Anvils;
    public override Color LineColor => new Color(255, 226, 217, 1);
}
