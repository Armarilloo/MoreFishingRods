using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class ChlorophyteDoubleRod : BaseModFishingRod
{
    public override int FishingPower => 40;
    public override int BobberProjectile => ModContent.ProjectileType<ChlorophyteBobber>();
    public override uint ProjectileCount => 2;
    public override int Value => Item.sellPrice(gold: 3);
    public override int Rarity => ItemRarityID.Lime;
    public override int CraftingIngredient => ItemID.ChlorophyteBar;
    public override int CraftingTile => TileID.MythrilAnvil;
    public override Color LineColor => new Color(234, 254, 126);

    public override bool CanFishInLava => true;
}
