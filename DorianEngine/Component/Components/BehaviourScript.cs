using Microsoft.Xna.Framework;

namespace DorianEngine.Component.Components
{
    public abstract class BehaviourScript : BaseComponent
    {
        // StartUp is called when the attached entity enters existence
        public virtual void Startup()
        {
            // User to implement own code by inheritance
        }

        // Update is called every frame
        public virtual void Update(GameTime gameTime)
        {
            // User to implement own code by inheritance
        }

        // FixedUpdate is to be used for physics
        public virtual void FixedUpdate(GameTime gameTime)
        {
            // User to implement own code by inheritance
        }
    }
}