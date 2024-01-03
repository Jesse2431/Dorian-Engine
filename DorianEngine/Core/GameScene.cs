using DorianEngine.Entities;
using Microsoft.Xna.Framework.Graphics;
using DorianEngine.Component.Components;

namespace DorianEngine.Core
{
    public class GameScene : SceneManager
    {
        public Lighting Lighting = new Lighting();

        public GameScene(GraphicsDevice device)
        {
            // NOTE: Here we hardcode anything that must be done for essential functioning, like the camera
            //       This might need to be redone, it's gonna become a horrendous mess real fast
            Entity camera = new Entity("CAMERA", new Transform());
            camera.AddComponent(new Camera());

            AddEntity(camera);
        }
    }
}
