using DorianEngine.Component.Components;
using DorianEngine.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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

                // CAMERA STUFF
                Camera camera = entity.GetComponent<Camera>();
                if(camera != null)
                {
                    entity.Transform.Position.Z = -5f;

                    camera.Update(entity.Transform.Position);
                }

                // WORLDCAMERA STUFF
                WavefrontModel wavefrontModel = entity.GetComponent<WavefrontModel>();
                if (wavefrontModel != null)
                {
                    //wavefrontModel.Model.Material.World = Matrix.CreateWorld(entity.Transform.Position, Vector3.Forward, camera.Up);
                    wavefrontModel.Model.Material.World = Matrix.Identity;
                    wavefrontModel.Model.Material.View = camera.View;
                    wavefrontModel.Model.Material.Projection = camera.Projection;
                }
            }
        }
    }
}