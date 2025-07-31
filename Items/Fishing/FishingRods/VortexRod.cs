using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MoreFishingRods.Projectiles.Typeless;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreFishingRods.Items.Fishing.FishingRods;

public class VortexRod : BaseModFishingRod
{
    public override int Width => 64;
    public override int Height => 64;
    public override int FishingPower => 50;
    public override int BobberProjectile => ModContent.ProjectileType<VortexBobber>();
    public override uint ProjectileCount => 3;
    public override int Value => Item.sellPrice(gold: 8, silver: 15);
    public override int Rarity => ItemRarityID.Cyan;
    public override int CraftingIngredient => (ItemID.FragmentVortex);
    public override int CraftingTile => TileID.LunarCraftingStation;
    public override Color LineColor => new Color(193, 255, 219, 1);

    public override bool CanFishInLava => true;
    public override Vector2 LineOriginOffset => new Vector2(Width, -57);

    public override void SetStaticDefaults()
    {
        Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(9, 7));
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
            .Request<Texture2D>("MoreFishingRods/Items/Fishing/FishingRods/VortexRod")
            .Value;

        int totalFrames = 7;
        int ticksPerFrame = 5;
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
