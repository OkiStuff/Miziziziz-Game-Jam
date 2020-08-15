using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Miziziziz_Game_Jam.Components;

namespace Miziziziz_Game_Jam
{
    public static class Functions
    {
        public static void Draw(ref Sprite sprite, ref Transform transform)
        {
            Globals.SpriteBatch.Draw(
                sprite.Texture,
                transform.Position,
                sprite.SourceRect,
                sprite.Color,
                transform.Rotation,
                new Vector2(sprite.Texture.Height * .5f, sprite.Texture.Width * .5f), 
                transform.Scale,
                SpriteEffects.None,
                0f
                );
        }
    }
}