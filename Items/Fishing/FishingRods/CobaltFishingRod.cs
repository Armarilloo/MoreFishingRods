using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class CobaltFishingRod : BaseModFishingRod
{
    public override void SetStaticDefaults()
    {
        ItemID.Sets.CanFishInLava[Item.type] = true;
        ItemID.Sets.IsLavaImmuneRegardlessOfRarity[Item.type] = true;
    }

    public override int FishingPower => 30;
    public override int BobberProjectile => ModContent.ProjectileType<CobaltBobber>();
    public override int Value => Item.sellPrice(gold: 1, silver: 55);
    public override int Rarity => ItemRarityID.LightRed;
    public override int CraftingIngredient => ItemID.CobaltBar;
    public override int CraftingTile => TileID.Anvils;
    public override Color LineColor => new Color(213, 239, 255, 1);
}
