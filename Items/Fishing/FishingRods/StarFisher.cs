using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class StarFisher : BaseModFishingRod
{
    public override int FishingPower => 20;
    public override int BobberProjectile => ModContent.ProjectileType<MeteoriteBobber>();
    public override int Value => Item.sellPrice(gold: 1, silver: 25);
    public override int Rarity => ItemRarityID.Blue;
    public override int CraftingIngredient => ItemID.MeteoriteBar;
    public override int CraftingTile => TileID.Anvils;
    public override Color LineColor => new Color(252, 200, 119, 1);

    public override bool CanFishInLava => true;
}
