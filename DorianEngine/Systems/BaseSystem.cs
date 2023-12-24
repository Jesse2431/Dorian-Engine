using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DorianEngine.Systems
{
    public abstract class BaseSystem
    {
        public virtual void Initialize()
        {
            // Base Initialize function to override
        }


        public virtual void LoadContent()
        {
            // Base LoadContent function to override
        }

        public virtual void Update(GameTime gameTime)
        {
            // Base Update function to override
        }

        public virtual void Draw(GameTime gameTime, GraphicsDevice device)
        {
            // Base Draw function to override
        }
    }
}
