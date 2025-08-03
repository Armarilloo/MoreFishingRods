using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class RodOfTheDeepOne : BaseModFishingRod
{
    public override int Width => 64;
    public override int Height => 64;
    public override int FishingPower => 60;
    public override int BobberProjectile => ModContent.ProjectileType<LuminiteBobber>();
    public override uint ProjectileCount => 4;
    public override int Value => Item.sellPrice(gold: 10);
    public override int Rarity => ItemRarityID.Red;
    public override int CraftingIngredient => (ItemID.LunarBar);
    public override int CraftingTile => TileID.LunarCraftingStation;
    public override Color LineColor => new Color(34, 221, 151, 1);

    public override bool CanFishInLava => true;
    public override Vector2 LineOriginOffset => new Vector2(60, -58);

    public override void SetStaticDefaults()
    {
        Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(15, 5));
        ItemID.Sets.AnimatesAsSoul[Type] = true;
    }

    public override bool PreDrawInInventory(
        SpriteBatch spriteBatch,
        Vector2 position,
        Rectangle frame,
        Color drawColor,
        Color itemColor,
        Vector2 origin,
        float scale
    )
    {
        Texture2D texture = ModContent
            .Request<Texture2D>("MoreFishingRods/Items/Fishing/FishingRods/RodOfTheDeepOne")
            .Value;

        int totalFrames = 5;
        int ticksPerFrame = 15;
        int currentFrame = (int)(Main.GameUpdateCount / ticksPerFrame) % totalFrames;
        int frameHeight = texture.Height / totalFrames;
        Rectangle sourceRect = new Rectangle(
            0,
            frameHeight * currentFrame,
            texture.Width,
            frameHeight
        );

        spriteBatch.Draw(
            texture,
            position,
            sourceRect,
            drawColor,
            0f,
            origin,
            scale,
            SpriteEffects.None,
            0f
        );
        return false;
    }
}
