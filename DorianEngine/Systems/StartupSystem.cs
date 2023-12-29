using DorianEngine.Component.Components;
using DorianEngine.Entities;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace DorianEngine.Systems
{
    public class StartupSystem : BaseSystem
    {
        GraphicsDevice device;
        List<Entity> entities;

        public StartupSystem(GraphicsDevice graphicsDevice, List<Entity> _entities)
        {
            device = graphicsDevice;
            entities = _entities;
        }

        public override void Startup()
        {
            foreach (Entity entity in entities)
            {
                BehaviourScript script = entity.GetComponent<BehaviourScript>();

                if (script != null)
                {
                    script.Startup();
                }

                List<Entity> _entities = entity.GetChildren();
                foreach (Entity _entity in _entities)
                {
                    BehaviourScript _script = _entity.GetComponent<BehaviourScript>();

                    if (_script != null)
                    {
                        _script.Startup();
                    }
                }
            }
        }
    }
}