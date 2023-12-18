using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DorianEngine.Component.Components
{
    public class Transform : IComponent
    {
        public Vector3 Position;
        public Vector3 Rotation;
        public Vector3 Scale;

        public Transform(Vector3 position, Vector3 rotation, Vector3 scale)
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;

            Setup();
        }

        public void Setup()
        {
            // Do something here or completely mark it as unused
        }

        public void Update(GameTime gameTime)
        {
            
        }
    }
}
