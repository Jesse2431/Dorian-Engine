using Microsoft.Xna.Framework;

namespace DorianEngine.Component.Components
{
    public class Transform : BaseComponent
    {
        // Global pos rot scl
        public Vector3 Position;
        public Vector3 Rotation;
        public Vector3 Scale;

        // Local pos rot scl
        private Vector3 LocalPosition;
        private Vector3 LocalRotation;
        private Vector3 LocalScale;

        // Create new transform code
        public Transform(Vector3 position, Vector3 rotation, Vector3 scale)
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
        }

        public Vector3 GetLocalPosition()
        {
            // TODO: Implement getting local position
            //       LocalPosition += Parent.GlobalPosition or something, not sure

            return LocalPosition;
        }

        public Vector3 GetLocalRotation()
        {
            // TODO: Implement getting local rotation

            return LocalRotation;
        }

        public Vector3 GetLocalScale()
        {
            // TODO: Implement getting local scale

            return LocalScale;
        }
    }
}
