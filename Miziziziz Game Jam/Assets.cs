using Microsoft.Xna.Framework.Graphics;

namespace Miziziziz_Game_Jam
{
    public static class Assets
    {
        public static Texture2D PlayerTexture;

        public static void Load()
        {
            PlayerTexture = Globals.Content.Load<Texture2D>("Sprites/tile402");
        }
    }
}