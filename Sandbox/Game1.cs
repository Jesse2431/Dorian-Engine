using DorianEngine.Core;
using Microsoft.Xna.Framework;
using System;

namespace Sandbox
{
    public class Game1 : GameEnvironment
    {
        // TODO: Do your top-level game management here.
        //       Only use it for stuff that you'll use globally, like setting
        //       default window title or initial console message

        public override void Startup()
        {
            // Do initial scene loading here
            GameScene currentScene = new Scenes.ExampleScene(GraphicsDevice);
            CurrentScene = currentScene;

            // Write something to the console
            Console.WriteLine
            (
                "Dorian Engine Sandbox example project. Made by Jesse in 2023\n" +
                "A simple showcase of what Dorian is capable of, and also the project template\n" +
                "\n" +
                "You may use the console for logging essential information, without having to code your own debug panel in-game.\n" +
                "The console may be disabled at any time by changing the Output Type in Properties of this project from Console Application to Windows Application.\n" +
                "\n" +
                "THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.\n"
            );
        }

        public override void UpdateGame(GameTime gameTime)
        {
            // Do global update functionality here, like setting window title
            Window.Title = "Dorian Engine Sandbox - " + Math.Round(1 / gameTime.ElapsedGameTime.TotalSeconds) + "FPS";
        }

        public override void DrawGame(GameTime gameTime)
        {
            // Do global drawing functionality here, like low-level DrawString() debug information
        }
    }
}