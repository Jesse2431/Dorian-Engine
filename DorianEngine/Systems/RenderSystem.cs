using DorianEngine.Component;
using DorianEngine.Component.Components;
using DorianEngine.Core;
using DorianEngine.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace DorianEngine.Systems
{
    public class RenderSystem : BaseSystem
    {
        GraphicsDevice Device;
        List<Entity> Entities;
        Lighting Lighting;
        SpriteBatch SpriteBatch;

        public RenderSystem(GraphicsDevice graphicsDevice, List<Entity> entities, Lighting lighting)
        {
            Device = graphicsDevice;
            Entities = entities;
            Lighting = lighting;
        }

        public override void Draw(GameTime gameTime, GraphicsDevice graphicsDevice)
        {
            // TODO: Implement rendering code here
            //       Like for 3d models and such
            Device = graphicsDevice;

            RasterizerState CullModeNone = new RasterizerState();
            CullModeNone.CullMode = CullMode.None;
            CullModeNone.FillMode = FillMode.WireFrame;
            //CullModeNone.MultiSampleAntiAlias = true;
            Device.RasterizerState = CullModeNone;

            foreach(Entity entity in Entities)
            {
                if(entity.GetComponent<WavefrontModel>() != null)
                {
                    WavefrontModel model = entity.GetComponent<WavefrontModel>();

                    // Setup lighting for the model
                    //model.Model.Material.

                    model.Draw(Device);
                }

                /*if(entity.GetComponent<TextComponentGUI>() != null)
                {
                    TextComponentGUI text = entity.GetComponent<TextComponentGUI>();

                    text.Draw(SpriteBatch);
                }*/
            }
        }
    }
}