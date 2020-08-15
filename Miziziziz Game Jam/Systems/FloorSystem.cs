using Microsoft.Xna.Framework;
using Miziziziz_Game_Jam.Components;

namespace Miziziziz_Game_Jam.Systems
{
    public class FloorSystem
    {
        public static Floor Left;
        public static Floor Right;

        public static void Load()
        {
            // left
            NewFloor(ref Left,Globals.PlayerSprite.Texture.Width + 550, Globals.ScreenMiddle.Y + 20, 98.9f, Color.Red);
            
        }

        private static void NewFloor(ref Floor floor, float Width, float Height, float Rotation, Color color)
        {
            floor = new Floor();
            floor.Sprite.Texture = Assets.FloorTexture;
            
            floor.Sprite.Color = color;
            floor.Transform.Position = new Vector2(Width, Height);
            floor.Transform.Rotation = Rotation;
            floor.Transform.Scale = new Vector2(4, 4);
        }

        public static void Update()
        {
            
        }

        public static void Draw()
        {
            Functions.Draw(ref Left.Sprite, ref Left.Transform);
        }
    }
}