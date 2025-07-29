using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class PalladiumFishingRod : BaseModFishingRod
{
    public override int FishingPower => 30;
    public override int BobberProjectile => ModContent.ProjectileType<PalladiumBobber>();
    public override int Value => Item.sellPrice(gold: 1, silver: 55);
    public override int Rarity => ItemRarityID.LightRed;
    public override int CraftingIngredient => ItemID.PalladiumBar;
    public override int CraftingTile => TileID.Anvils;
    public override Color LineColor => new Color(247, 214, 196, 1);

    public override bool CanFishInLava => true;
}
