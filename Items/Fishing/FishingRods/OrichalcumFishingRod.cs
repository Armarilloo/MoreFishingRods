using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class OrichalcumFishingRod : BaseModFishingRod
{
    public override int FishingPower => 33;
    public override int BobberProjectile => ModContent.ProjectileType<OrichalcumBobber>();
    public override int Value => Item.sellPrice(gold: 2);
    public override int Rarity => ItemRarityID.LightRed;
    public override int CraftingIngredient => ItemID.OrichalcumBar;
    public override int CraftingTile => TileID.MythrilAnvil;
    public override Color LineColor => new Color(255, 241, 254, 1);

    public override bool CanFishInLava => true;
}
