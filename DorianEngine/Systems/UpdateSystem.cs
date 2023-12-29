using DorianEngine.Component.Components;
using DorianEngine.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace DorianEngine.Systems
{
    public class UpdateSystem : BaseSystem
    {
        // TODO: Implement UpdateSystem for updating from each entity's components that have Update() functions
        //       For stuff like updating Vector3's or other things involving updating

        GraphicsDevice device;
        List<Entity> entities;

        public UpdateSystem(GraphicsDevice graphicsDevice, List<Entity> _entities)
        {
            device = graphicsDevice;
            entities = _entities;
        }

        public override void Update(GameTime gameTime)
        {
            foreach (Entity entity in entities)
            {
                BehaviourScript script = entity.GetComponent<BehaviourScript>();

                if (script != null)
                {
                    script.Update(gameTime);
                }

                List<Entity> _entities = entity.GetChildren();
                foreach(Entity _entity in _entities)
                {
                    BehaviourScript _script = _entity.GetComponent<BehaviourScript>();

                    if(_script != null)
                    {
                        _script.Update(gameTime);
                    }
                }
            }
        }
    }
}