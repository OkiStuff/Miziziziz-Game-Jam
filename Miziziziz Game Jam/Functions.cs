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
                Vector2.Zero,
                transform.Scale,
                SpriteEffects.None,
                0f
                );
        }
    }
}