using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class Shroomcaster : BaseModFishingRod
{
    public override int FishingPower => 45;
    public override int BobberProjectile => ModContent.ProjectileType<ShroomiteBobber>();
    public override uint ProjectileCount => 2;
    public override int Value => Item.sellPrice(gold: 5, silver: 50);
    public override int Rarity => ItemRarityID.Yellow;
    public override int CraftingIngredient => ItemID.ShroomiteBar;
    public override int CraftingTile => TileID.MythrilAnvil;
    public override Color LineColor => new Color(140, 238, 255);

    public override bool CanFishInLava => true;
}
