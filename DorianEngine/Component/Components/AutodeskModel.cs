/// <summary>
/// This doesn't actually do anything yet, because it isn't the primary 3D format to be used.
/// I'll implement it somewhere in the future.
/// </summary>

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace DorianEngine.Component.Components
{
    public class AutodeskModel : IDrawableComponent
    {
        public string FilePath;
        public Model Model;

        public AutodeskModel(string filePath, GraphicsDevice device)
        {
            FilePath = filePath;

            ConstructModel(device);
            Setup();
        }

        public void ConstructModel(GraphicsDevice device)
        {
            List<ModelMesh> meshes = new List<ModelMesh>();
            List<ModelBone> bones = new List<ModelBone>();

            Model = new Model(device, bones, meshes);
        }

        public void Setup()
        {

        }

        public void Draw(GraphicsDevice device)
        {

        }

        public void Update(GameTime gameTime)
        {

        }
    }
}
