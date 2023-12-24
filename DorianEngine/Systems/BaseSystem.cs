using Microsoft.Xna.Framework;

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

        public virtual void Draw(GameTime gameTime)
        {
            // Base Draw function to override
        }
    }
}
