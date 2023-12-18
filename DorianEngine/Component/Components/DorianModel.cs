using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace DorianEngine.Component.Components
{
    public class DorianModel : IDrawableComponent
    {
        public List<Submodel> Submodels;
        public string FilePath;

        public DorianModel(string filePath)
        {
            FilePath = filePath;

            Setup();
        }

        public void Setup()
        {
            Submodels = new List<Submodel>();
        }

        public void Draw(GraphicsDevice device)
        {

        }

        public void Update(GameTime gameTime)
        {

        }
    }

    public class Submodel
    {

    }
}
