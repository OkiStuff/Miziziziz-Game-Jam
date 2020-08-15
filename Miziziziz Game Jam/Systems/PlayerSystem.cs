using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Miziziziz_Game_Jam.Components;

namespace Miziziziz_Game_Jam.Systems
{
    public class PlayerSystem
    {
        public static Player Player;

        public static void Load()
        {
            Player = new Player();
            Player.Sprite.Texture = Assets.PlayerTexture;
            Player.Sprite.Color = Color.White;
            
            Player.Transform.Scale = new Vector2(4,4);
        }

        public static void Update()
        {
            if (Input.IsKeyPressed(Keys.W))
            {
                Console.WriteLine("moving up");
            }
            
            else if (Input.IsKeyPressed(Keys.A))
            {
                Console.WriteLine("moving left");
            }
            
            else if (Input.IsKeyPressed(Keys.D))
            {
                Console.WriteLine("Moving Right");
            }
            
            else if (Input.IsKeyPressed(Keys.S))
            {
                Console.WriteLine("Moving Back");
            }
            
        }

        public static void Draw()
        {
            Functions.Draw(ref Player.Sprite, ref Player.Transform);
        }
    }
}