using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class SpectralFishingRod : BaseModFishingRod
{
    public override int FishingPower => 45;
    public override int BobberProjectile => ModContent.ProjectileType<SpectralBobber>();
    public override uint ProjectileCount => 2;
    public override int Value => Item.sellPrice(gold: 5);
    public override int Rarity => ItemRarityID.Yellow;
    public override int CraftingIngredient => ItemID.SpectreBar;
    public override int CraftingTile => TileID.MythrilAnvil;
    public override Color LineColor => new Color(223, 255, 249);
}
