using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class TitaniumFishingRod : BaseModFishingRod
{
    public override void SetStaticDefaults()
    {
        ItemID.Sets.CanFishInLava[Item.type] = true;
        ItemID.Sets.IsLavaImmuneRegardlessOfRarity[Item.type] = true;
    }

    public override int FishingPower => 35;
    public override int BobberProjectile => ModContent.ProjectileType<TitaniumBobber>();
    public override int Value => Item.sellPrice(gold: 2, silver: 15);
    public override int Rarity => ItemRarityID.LightRed;
    public override int CraftingIngredient => ItemID.TitaniumBar;
    public override int CraftingTile => TileID.MythrilAnvil;
    public override Color LineColor => new Color(208, 208, 208, 1);
}
