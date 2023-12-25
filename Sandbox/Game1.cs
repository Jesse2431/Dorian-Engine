using DorianEngine.Core;
using Microsoft.Xna.Framework.Graphics;

namespace Sandbox
{
    public class Game1 : GameEnvironment
    {
        // TODO: Do your top-level game management here.
        //       Divide it all into different scenes and make that all go thru here
        //       InitializeGame should be used to set the first scene to be loaded
        //       From here or elsewhere you want to do the functionality for for example
        //       changing scenes.

        public override void Startup()
        {
            // Do initial scene loading here
            GameScene currentScene = new Scenes.ExampleScene(GraphicsDevice);
            CurrentScene = currentScene;
        }

        public override void UpdateGame()
        {
            // Do global update functionality here
        }

        public override void DrawGame()
        {
            // Do global drawing functionality here
        }
    }
}