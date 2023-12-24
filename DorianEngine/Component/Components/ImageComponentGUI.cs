using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DorianEngine.Component.Components
{
    public class ImageComponentGUI : BaseComponent
    {
        public Texture2D Image;

        public float Width;
        public float Height;

        public Vector2 Position;
        public Vector2 Rotation;

        public ImageComponentGUI(Texture2D image, float width, float height)
        {
            Image = image;
            Width = width;
            Height = height;
        }

        public void Draw(SpriteBatch spriteBatch, GraphicsDevice device)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Image, Position, Color.White);
            spriteBatch.End();
        }
    }
}
