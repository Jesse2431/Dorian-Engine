using DorianEngine.Core;
using Sandbox.Scenes;

namespace Sandbox
{
    public class Game1 : GameEnvironment
    {
        // TODO: Do your top-level game management here.
        //       Divide it all into different scenes and make that all go thru here
        //       InitializeGame should be used to set the first scene to be loaded
        //       From here or elsewhere you want to do the functionality for for example
        //       changing scenes.

        public override void InitializeGame()
        {
            GameScene currentScene = new ExampleScene(GraphicsDevice);
            CurrentScene = currentScene;
        }
    }
}