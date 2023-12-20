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
            foreach(ModelMesh mesh in Model.Meshes)
            {
                foreach(BasicEffect effect in mesh.Effects)
                {
                    // TODO: Implement generalised lighting settings here
                }
            }
        }

        public void Draw(GraphicsDevice device)
        {
            foreach(ModelMesh mesh in Model.Meshes)
            {
                foreach (BasicEffect effect in mesh.Effects)
                {
                    // TODO: Pass this all onto camera instead of hardcoding
                    effect.World = Matrix.CreateWorld(Vector3.Zero, Vector3.Forward, Vector3.Up);
                    effect.View = Matrix.CreateLookAt(Vector3.Zero, Vector3.Forward, Vector3.Up);
                    effect.Projection = Matrix.CreatePerspectiveFieldOfView(45f, device.DisplayMode.AspectRatio, 0.01f, 1000f);
                }

                mesh.Draw();
            }
        }

        public void Update(GameTime gameTime)
        {
            // TODO: Implement update stuff for the model here
            //       Altho, are we really gonna use it?
        }
    }
}
