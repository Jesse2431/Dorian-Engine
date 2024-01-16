using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DorianEngine.Core;
using System;

namespace DorianEngine.Component.Components
{
    public class Camera : BaseComponent
    {
        // TODO: Implement camera here
        //       Everything camera related MUST be done here
        //       Like World, View and Projection
        //       RenderSystem should be a communication line between BasicEffect and Camera then
        public Matrix View;
        public Matrix Projection;
        public Matrix Rotation = Matrix.CreateFromYawPitchRoll(MathExtension.ToRadians(0), 0, 0);

        public Vector3 Up;

        public Camera(GraphicsDevice device, float FieldOfView)
        {
            // TODO: Do setup stuff here
            Up = Vector3.Up;

            View = Matrix.CreateLookAt(Vector3.Zero, Vector3.Forward, Up);
            Projection = Matrix.CreatePerspectiveFieldOfView(FieldOfView * (((float)Math.PI) / 180), device.DisplayMode.AspectRatio, 0.01f, 1000f);
        }

        public void Update(Vector3 CameraPosition)
        {
            Vector3 Target = new Vector3(0, 0, 1);
            //Rotation = Matrix.CreateFromYawPitchRoll(MathExtension.ToRadians(0), 0, 0);
            Target = Vector3.TransformNormal(Target, Rotation);
            Target = CameraPosition + Target;

            View = Matrix.CreateLookAt(CameraPosition, Target, Up);
        }
    }
}