using Microsoft.Xna.Framework;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class TestRod1 : BaseModFishingRod
{
    public override int Width => 64;
    public override int Height => 64;
    public override int FishingPower => 1000;
    public override int BobberProjectile => ModContent.ProjectileType<TestBobber1>();
    public override int Value => Item.sellPrice(gold: 2, silver: 15);
    public override int Rarity => ItemRarityID.LightRed;
    public override int CraftingIngredient => ModContent.ItemType<TestRod1>();
    public override int CraftingTile => TileID.ChlorophyteExtractinator;
    public override Color LineColor => new Color(208, 208, 208, 1);

    public override bool CanFishInLava => true;
    public override Vector2 LineOriginOffset => new Vector2(Width, -Height);

    public override void SetDefaults()
    {
        base.SetDefaults();
        Item.shootSpeed = 200f;
        Item.damage = 1000;
    }
}
