using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using DorianEngine.Core;
using System.Globalization;
using System.IO;

namespace DorianEngine.Component.Components
{
    public class WavefrontModel : BaseComponent
    {
        public struct WavefrontModelData
        {
            public Material Material;
            public string Name;

            public VertexPositionNormalTexture[] VertexArray;
            public int[] IndexArray;
        }

        public WavefrontModelData Model = new WavefrontModelData();
        public string FilePath;
        private GraphicsDevice device;
        public List<VertexPositionNormalTexture> VertexList = new List<VertexPositionNormalTexture>();

        public WavefrontModel(string filePath, GraphicsDevice graphicsDevice)
        {
            FilePath = filePath;
            device = graphicsDevice;

            Load();
        }

        public void Load()
        {
            // Don't mind it. I'll fix it someday
            List<Vector3> vertices = new List<Vector3>();
            List<Vector3> normals = new List<Vector3>();
            List<Vector2> textureCoords = new List<Vector2>();
            List<int> indices = new List<int>();

            using (StreamReader sr = new StreamReader(FilePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    switch (parts[0])
                    {
                        case "v":  // Vertex
                            float x = float.Parse(parts[1], CultureInfo.InvariantCulture); //float x = float.Parse(parts[1]);
                            float z = float.Parse(parts[2], CultureInfo.InvariantCulture); //float y = float.Parse(parts[2]);
                            float y = float.Parse(parts[3], CultureInfo.InvariantCulture); //float z = float.Parse(parts[3]);
                            vertices.Add(new Vector3(x, y, z));
                            break;
                        case "vt":  // Texture coordinate
                            float u = float.Parse(parts[1], CultureInfo.InvariantCulture); //float u = float.Parse(parts[1]);
                            float v = float.Parse(parts[2], CultureInfo.InvariantCulture); //float v = float.Parse(parts[2]);
                            textureCoords.Add(new Vector2(u, v));
                            break;
                        case "vn":  // Vertex normal
                            float nx = float.Parse(parts[1], CultureInfo.InvariantCulture);
                            float ny = float.Parse(parts[2], CultureInfo.InvariantCulture);
                            float nz = float.Parse(parts[3], CultureInfo.InvariantCulture);
                            normals.Add(new Vector3(nx, ny, nz));
                            break;

                        case "f":  // Face
                            for (int i = 1; i < parts.Length; i++)
                            {
                                string[] subparts = parts[i].Split('/');
                                int vIndex = int.Parse(subparts[0]) - 1;
                                int tIndex = int.Parse(subparts[1]) - 1;
                                int nIndex = int.Parse(subparts[2]) - 1;

                                VertexPositionNormalTexture vertex = new VertexPositionNormalTexture(vertices[vIndex], normals[nIndex], textureCoords[tIndex]);
                                VertexList.Add(vertex);
                                indices.Add(VertexList.Count - 1);
                            }
                            break;
                    }
                }
            }

            Model.VertexArray = VertexList.ToArray();
            Model.IndexArray = indices.ToArray();
        }

        public void Draw(GraphicsDevice device)
        {
            foreach (EffectPass pass in Model.Material.CurrentTechniquePasses)
            {
                pass.Apply();

                // TODO: Pass this all onto camera instead of hardcoding
                //Model.Material.World = Matrix.CreateWorld(new Vector3(0, 0, -5), Vector3.Forward, Vector3.Up);
                //Model.Material.View = Matrix.CreateLookAt(Vector3.Zero, Vector3.Forward, Vector3.Up);
                //Model.Material.Projection = Matrix.CreatePerspectiveFieldOfView(0.78f, device.DisplayMode.AspectRatio, 0.01f, 1000f);

                // TODO: Implement global Vertex and Index buffer for handling 3D rendering instead of DrawUserIndexedPrimitives
                device.DrawUserIndexedPrimitives(
                    PrimitiveType.TriangleList,
                    Model.VertexArray,
                    0,
                    Model.VertexArray.Length,
                    Model.IndexArray,
                    0,
                    Model.IndexArray.Length / 3
                );
            }
        }
    }
}
