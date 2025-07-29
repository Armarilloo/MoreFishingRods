using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class MythrilFishingRod : BaseModFishingRod
{
    public override int FishingPower => 33;
    public override int BobberProjectile => ModContent.ProjectileType<MythrilBobber>();
    public override int Value => Item.sellPrice(gold: 2);
    public override int Rarity => ItemRarityID.LightRed;
    public override int CraftingIngredient => ItemID.TitaniumBar;
    public override int CraftingTile => TileID.MythrilAnvil;
    public override Color LineColor => new Color(212, 255, 190, 1);

    public override bool CanFishInLava => true;
}
