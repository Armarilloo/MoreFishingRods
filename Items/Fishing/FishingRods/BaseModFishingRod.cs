using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public abstract class BaseModFishingRod : ModItem
{
    public virtual int Width => 48;
    public virtual int Height => 48;

    public virtual SoundStyle? UseSound => SoundID.Item1;
    public abstract int FishingPower { get; }

    public abstract int BobberProjectile { get; }
    public abstract int Value { get; }
    public abstract int Rarity { get; }

    public abstract int CraftingIngredient { get; }
    public abstract int CraftingTile { get; }

    public override void SetDefaults()
    {
        Item.width = Width;
        Item.height = Height;
        Item.useAnimation = 8;
        Item.useTime = 8;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.UseSound = UseSound;
        Item.fishingPole = FishingPower;
        Item.shootSpeed = 14.5f;
        Item.shoot = BobberProjectile;
        Item.value = Value;
        Item.rare = Rarity;
    }

    public override void ModifyFishingLine(
        Projectile bobber,
        ref Vector2 lineOriginOffset,
        ref Color lineColor
    )
    {
        lineOriginOffset = new Vector2(47f, -33f);
        lineColor = new Color(208, 208, 208);
    }

    public override void AddRecipes()
    {
        CreateRecipe().AddIngredient(CraftingIngredient, 6).AddTile(CraftingTile).Register();
    }
}
