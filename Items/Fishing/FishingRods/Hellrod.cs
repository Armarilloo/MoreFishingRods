using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class Hellrod : BaseModFishingRod
{
    public override int FishingPower => 25;
    public override int BobberProjectile => ModContent.ProjectileType<HellstoneBobber>();
    public override int Value => Item.sellPrice(gold: 1);
    public override int Rarity => ItemRarityID.Orange;
    public override int CraftingIngredient => ItemID.HellstoneBar;
    public override int CraftingTile => TileID.Anvils;
    public override Color LineColor => new Color(254, 233, 159, 1);
    public override bool CanFishInLava => true;
}
