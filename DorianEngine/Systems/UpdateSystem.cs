using DorianEngine.Component.Components;
using DorianEngine.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace DorianEngine.Systems
{
    public class UpdateSystem : BaseSystem
    {
        // TODO: Implement UpdateSystem for updating from each entity's components that have Update() functions
        //       For stuff like updating Vector3's or other things involving updating

        GraphicsDevice device;
        List<Entity> entities;
        Camera cam;

        List<UpdateSystem> PluginSystems;

        // TODO: De-hardcode this
        float yaw;      // From top view, the rotation
        float pitch;    // From side view, the rotation
        float roll;     // From front-rear view, the rotation

        public UpdateSystem(GraphicsDevice graphicsDevice, List<Entity> _entities)
        {
            device = graphicsDevice;
            entities = _entities;

            foreach(UpdateSystem system in PluginSystems)
            {
                system;
            }
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
                    #region DEBUG_CAMERA_FPS
                    // CAMERA MOVEMENT IN POSITION
                    if (Keyboard.GetState().IsKeyDown(Keys.W))
                    {
                        entity.Transform.Position.Z += 0.01f;
                    }

                    if (Keyboard.GetState().IsKeyDown(Keys.S))
                    {
                        entity.Transform.Position.Z -= 0.01f;
                    }

                    if (Keyboard.GetState().IsKeyDown(Keys.A))
                    {
                        entity.Transform.Position.X -= 0.01f;
                    }

                    if (Keyboard.GetState().IsKeyDown(Keys.D))
                    {
                        entity.Transform.Position.X += 0.01f;
                    }

                    if (Keyboard.GetState().IsKeyDown(Keys.E))
                    {
                        entity.Transform.Position.Y += 0.01f;
                    }

                    if (Keyboard.GetState().IsKeyDown(Keys.Q))
                    {
                        entity.Transform.Position.Y -= 0.01f;
                    }

                    // CAMERA MOVEMENT IN ROTATION
                    if (Keyboard.GetState().IsKeyDown(Keys.Up))
                    {
                        pitch += 0.01f;
                        //camera.Rotation += Matrix.CreateFromYawPitchRoll(yaw, pitch, roll);
                        camera.Rotation += Matrix.CreateRotationX(pitch);
                    }

                    if (Keyboard.GetState().IsKeyDown(Keys.Down))
                    {
                        pitch -= 0.01f;
                        //camera.Rotation += Matrix.CreateFromYawPitchRoll(yaw, pitch, roll);
                        camera.Rotation -= Matrix.CreateRotationX(pitch);
                    }

                    if (Keyboard.GetState().IsKeyDown(Keys.Left))
                    {
                        yaw += 0.01f;
                        //camera.Rotation += Matrix.CreateFromYawPitchRoll(yaw, pitch, roll);
                        camera.Rotation += Matrix.CreateRotationY(yaw);
                    }

                    if (Keyboard.GetState().IsKeyDown(Keys.Right))
                    {
                        yaw -= 0.01f;
                        //camera.Rotation += Matrix.CreateFromYawPitchRoll(yaw, pitch, roll);
                        camera.Rotation -= Matrix.CreateRotationY(yaw);
                    }
                    #endregion

                    camera.Update(entity.Transform.Position);
                    cam = camera;
                }

                // WORLDCAMERA STUFF
                WavefrontModel wavefrontModel = entity.GetComponent<WavefrontModel>();
                if (wavefrontModel != null)
                {
                    wavefrontModel.Model.Material.World = Matrix.CreateWorld(entity.Transform.Position, Vector3.Forward, Vector3.Up);
                    //wavefrontModel.Model.Material.World = Matrix.Identity;
                    wavefrontModel.Model.Material.View = cam.View;
                    wavefrontModel.Model.Material.Projection = cam.Projection;
                }
            }

            foreach(UpdateSystem system in PluginSystems)
            {
                system.Update(gameTime);
            }
        }
    }
}