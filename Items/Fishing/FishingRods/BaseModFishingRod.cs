using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
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
    public virtual uint ProjectileCount => 1;
    public abstract int Value { get; }
    public abstract int Rarity { get; }

    public abstract int CraftingIngredient { get; }
    public abstract int CraftingTile { get; }

    public virtual Color LineColor => new Color(208, 208, 208);

    public virtual bool CanFishInLava => false;

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

    public override void SetStaticDefaults()
    {
        ItemID.Sets.CanFishInLava[Item.type] = ItemID.Sets.IsLavaImmuneRegardlessOfRarity[
            Item.type
        ] = CanFishInLava;
    }

    public override void ModifyFishingLine(
        Projectile bobber,
        ref Vector2 lineOriginOffset,
        ref Color lineColor
    )
    {
        lineOriginOffset = new Vector2(47f, -33f);
        lineColor = LineColor;
    }

    public override void AddRecipes()
    {
        CreateRecipe().AddIngredient(CraftingIngredient, 8).AddTile(CraftingTile).Register();
    }

    public override bool Shoot(
        Player player,
        EntitySource_ItemUse_WithAmmo source,
        Vector2 position,
        Vector2 velocity,
        int type,
        int damage,
        float knockback
    )
    {
        for (var i = 0; i < ProjectileCount; i++)
        {
            Projectile.NewProjectile(
                source,
                position,
                velocity.RotatedByRandom(MathHelper.ToRadians(18f)),
                type,
                0,
                0f,
                player.whoAmI,
                ai2: Main.rand.Next(2)
            );
        }
        return false;
    }
}
