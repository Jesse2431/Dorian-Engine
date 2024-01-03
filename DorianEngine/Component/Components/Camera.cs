using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DorianEngine.Core;
using System;
using DorianEngine.Entities;

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
        public Matrix Rotation;

        public Vector3 Target;
        public Vector3 Up;

        public Camera(GraphicsDevice device, float FieldOfView)
        {
            // TODO: Do setup stuff here
            Target = new Vector3(0, 0, 1);
            Up = Vector3.Up;

            View = Matrix.CreateLookAt(Vector3.Zero, Target, Up);
            Projection = Matrix.CreatePerspectiveFieldOfView(FieldOfView * (((float)Math.PI) / 180), device.DisplayMode.AspectRatio, 0.01f, 1000f);
        }

        public void Update(Vector3 CameraPosition)
        {
            Rotation = Matrix.CreateFromYawPitchRoll(MathExtension.ToRadians(90f), 0, 0);
            Target = Vector3.TransformNormal(Target, Rotation);
            Target = CameraPosition + Target;
        }
    }
}