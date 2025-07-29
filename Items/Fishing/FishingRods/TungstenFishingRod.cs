using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class TungstenFishingRod : BaseModFishingRod
{
    public override int FishingPower => 16;
    public override int BobberProjectile => ModContent.ProjectileType<TungstenBobber>();
    public override int Value => Item.sellPrice(silver: 50);
    public override int Rarity => ItemRarityID.White;
    public override int CraftingIngredient => ItemID.TungstenBar;
    public override int CraftingTile => TileID.Anvils;
    public override Color LineColor => new Color(238, 255, 241, 1);
}
