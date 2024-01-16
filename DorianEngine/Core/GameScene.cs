using DorianEngine.Entities;
using Microsoft.Xna.Framework.Graphics;
using DorianEngine.Component.Components;
using DorianEngine.Systems;

namespace DorianEngine.Core
{
    public class GameScene : SceneManager
    {
        public Lighting Lighting = new Lighting();

        public GameScene(GraphicsDevice device)
        {
            // NOTE: Here we hardcode anything that must be done for essential functioning, like the camera
            //       This might need to be redone, it's gonna become a horrendous mess real fast
        }

        public void SetupScene(GraphicsDevice device)
        {
            AddSystem(new StartupSystem(device, Entities));
            AddSystem(new RenderSystem(device, Entities, Lighting));
            AddSystem(new UpdateSystem(device, Entities));
        }
    }
}
