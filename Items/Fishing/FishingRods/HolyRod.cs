using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class HolyRod : BaseModFishingRod
{
    public override int FishingPower => 33;
    public override int BobberProjectile => ModContent.ProjectileType<HallowedBobber>();
    public override int Value => Item.sellPrice(gold: 3, silver: 25);
    public override int Rarity => ItemRarityID.Pink;
    public override int CraftingIngredient => ItemID.HallowedBar;
    public override int CraftingTile => TileID.MythrilAnvil;
    public override Color LineColor => new Color(250, 232, 136, 1);

    public override bool CanFishInLava => true;
}
