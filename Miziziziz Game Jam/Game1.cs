using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Miziziziz_Game_Jam.Systems;

namespace Miziziziz_Game_Jam
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        public Game1()
        {
            Globals.Graphics = new GraphicsDeviceManager(this);
            Globals.Content = Content;
            Content.RootDirectory = "Content";
            
        }
        
        protected override void Initialize()
        {
            IsMouseVisible = true;
            Window.AllowAltF4 = true;

            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            Globals.SpriteBatch = new SpriteBatch(GraphicsDevice);

            Assets.Load();
            PlayerSystem.Load();
        }
        
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            Input.UpdateState();

            PlayerSystem.Update();

            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            Globals.SpriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.Default, RasterizerState.CullNone);;
            PlayerSystem.Draw();
            Globals.SpriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
