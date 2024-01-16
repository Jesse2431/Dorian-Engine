using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DorianEngine.Core
{
    public abstract class GameEnvironment : Game
    {
        private GraphicsDeviceManager _graphics;
        public SpriteBatch _spriteBatch;
        public GameScene CurrentScene;

        public GameEnvironment()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Startup();
            CurrentScene.Startup();
            base.Initialize();

            _graphics.PreferredBackBufferWidth = GraphicsDevice.DisplayMode.Width;
            _graphics.PreferredBackBufferHeight = GraphicsDevice.DisplayMode.Height;
            _graphics.IsFullScreen = true;
            //_graphics.GraphicsProfile = GraphicsProfile.HiDef;
            //_graphics.PreferMultiSampling = true;
            //GraphicsDevice.PresentationParameters.MultiSampleCount = 8;
            //_graphics.ApplyChanges();
        }

        public abstract void Startup();

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            CurrentScene.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            CurrentScene.Update(gameTime);
            UpdateGame(gameTime);
            base.Update(gameTime);
        }

        public abstract void UpdateGame(GameTime gameTime);

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            CurrentScene.Draw(gameTime, GraphicsDevice);
            DrawGame(gameTime);
            base.Draw(gameTime);
        }

        public abstract void DrawGame(GameTime gameTime);
    }
}