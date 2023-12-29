using DorianEngine.Component.Components;
using DorianEngine.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace DorianEngine.Systems
{
    public class RenderSystem : BaseSystem
    {
        GraphicsDevice device;
        List<Entity> entities;

        public RenderSystem(GraphicsDevice graphicsDevice, List<Entity> _entities)
        {
            device = graphicsDevice;
            entities = _entities;
        }

        public override void Draw(GameTime gameTime, GraphicsDevice device)
        {
            // TODO: Implement rendering code here
            //       Like for 3d models and such
        }
    }
}